namespace Contract_Monthly_Claim_System
{
    /// <summary>
    /// Joshua Gain 
    /// ST10369044
    /// PROG6212
    /// Group 1
    /// </summary>
    /// <Refernces>
    /// Link:https://www.w3schools.com/asp/razor_syntax.asp
    /// Link:https://www.youtube.com/watch?v=xuFdrXqpPB0
    /// </Refernces>
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
