using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using MyShowCase.Data.EF;
using MyShowCase.Data.EF.Entities;

namespace MyShowCase.Data
{
	public class ContentStore
	{
		private readonly IDbContextFactory<AppDbContext> _dbFactory;
		private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web)
		{
			WriteIndented = true
		};

		public ContentStore(IDbContextFactory<AppDbContext> dbFactory)
		{
			_dbFactory = dbFactory;
		}

		private static string ComposeKey(string key, string? id)
		{
			return string.IsNullOrWhiteSpace(id) ? key : $"{key}:{id}";
		}

		public async Task<T?> GetAsync<T>(string key)
		{
			using var db = await _dbFactory.CreateDbContextAsync();
			await db.Database.EnsureCreatedAsync();
			var item = await db.ContentItems.AsNoTracking().FirstOrDefaultAsync(x => x.Key == key);
			if (item == null || string.IsNullOrWhiteSpace(item.Json)) return default;
			return JsonSerializer.Deserialize<T>(item.Json, JsonOptions);
		}

		public async Task<T?> GetAsync<T>(string key, string? id)
		{
			return await GetAsync<T>(ComposeKey(key, id));
		}

		public async Task UpsertAsync<T>(string key, T value)
		{
			using var db = await _dbFactory.CreateDbContextAsync();
			await db.Database.EnsureCreatedAsync();
			var json = JsonSerializer.Serialize(value, JsonOptions);
			var existing = await db.ContentItems.FirstOrDefaultAsync(x => x.Key == key);
			if (existing == null)
			{
				db.ContentItems.Add(new ContentItem { Key = key, Json = json, UpdatedUtc = DateTime.UtcNow });
			}
			else
			{
				existing.Json = json;
				existing.UpdatedUtc = DateTime.UtcNow;
			}
			await db.SaveChangesAsync();
		}

		public async Task UpsertAsync<T>(string key, string? id, T value)
		{
			await UpsertAsync(ComposeKey(key, id), value);
		}

		public async Task DeleteAsync(string key)
		{
			using var db = await _dbFactory.CreateDbContextAsync();
			await db.Database.EnsureCreatedAsync();
			var existing = await db.ContentItems.FirstOrDefaultAsync(x => x.Key == key);
			if (existing != null)
			{
				db.ContentItems.Remove(existing);
				await db.SaveChangesAsync();
			}
		}

		public async Task DeleteAsync(string key, string? id)
		{
			await DeleteAsync(ComposeKey(key, id));
		}
	}
}
