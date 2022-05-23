using CronBlocks.ACMEv2.WebInterface;

namespace CronBlocks.ACMEv2WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

            //
            // Add services to the container
            //
            builder.Services.AddRazorPages();
            builder.Services.AddACMEv2(); //---> ACMEv2

            WebApplication? app = builder.Build();

            //
            // Configure the HTTP request pipeline
            //
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseACMEv2(); //---> ACMEv2

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}