using Microsoft.EntityFrameworkCore;
using MVCTask2.DAL;

namespace MVCTask2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();
			string connectionStr = "Server= DESKTOP-D9KR3VR\\SQLEXPRESS;Database=ClinicAppDb;Trusted_Connection=True;TrustServerCertificate = True";

                builder.Services.AddDbContext<AppDbContext>(opt=>
			opt.UseSqlServer(connectionStr));

			var app = builder.Build();
			app.UseStaticFiles();
			app.MapControllerRoute(
	name: "Default",
   pattern: "{controller=Home}/{action=index}/{id?}"
	);

			app.Run();
		}
	}
}
