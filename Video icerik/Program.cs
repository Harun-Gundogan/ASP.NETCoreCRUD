using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Video_icerik.Data;
namespace Video_icerik
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<VideoicerikContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("VideoicerikContext") ?? throw new InvalidOperationException("Connection string 'VideoicerikContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Iceriks/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Iceriks}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
