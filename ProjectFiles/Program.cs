using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using MyShowCase.Data.EF;
using MyShowCase.Data;

namespace MyShowCase
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");
			builder.RootComponents.Add<HeadOutlet>("head::after");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

			// Initialize SQLite (WASM)
			SQLitePCL.Batteries_V2.Init();

			// Register EF Core with SQLite in WASM
			builder.Services.AddDbContextFactory<AppDbContext>(options =>
				options.UseSqlite("Data Source=app.db"));

			// Content storage service
			builder.Services.AddScoped<ContentStore>();

			await builder.Build().RunAsync();
		}
	}
}
