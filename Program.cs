using static WebEmpty.Models.Repository;

namespace WebEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IRepository, ProductRepository>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Create" });

            app.Run();
        }
    }
}