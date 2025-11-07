using Microsoft.EntityFrameworkCore;
using MyShowCase.Data.EF.Entities;

namespace MyShowCase.Data.EF
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<ContactMessage> ContactMessages => Set<ContactMessage>();
		public DbSet<ContentItem> ContentItems => Set<ContentItem>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ContactMessage>(entity =>
			{
				entity.HasKey(e => e.Id);
				entity.Property(e => e.Name).HasMaxLength(200).IsRequired();
				entity.Property(e => e.Email).HasMaxLength(320).IsRequired();
				entity.Property(e => e.Subject).HasMaxLength(200);
				entity.Property(e => e.Message).IsRequired();
				entity.Property(e => e.CreatedUtc).HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
			});

			modelBuilder.Entity<ContentItem>(entity =>
			{
				entity.HasKey(e => e.Id);
				entity.HasIndex(e => e.Key).IsUnique();
				entity.Property(e => e.Key).HasMaxLength(100).IsRequired();
				entity.Property(e => e.Json).IsRequired();
			});
		}
	}
}
