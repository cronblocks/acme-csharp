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

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}