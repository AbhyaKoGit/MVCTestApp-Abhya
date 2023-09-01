using Microsoft.EntityFrameworkCore;
using MVCTestApp.BAL.Inferaces;
using MVCTestApp.BAL.Services;
using MVCTestApp.DAL.DataContext;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.DAL.Services;

namespace MVCTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DbDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));
            builder.Services.AddTransient<ILoginRepo, LoginRepo>();
            builder.Services.AddTransient<ILoginService, LoginService>();
            builder.Services.AddTransient<ISignUpRepo, SignupRepo>();
            builder.Services.AddTransient<ISignUpService, SignUpService>();
            builder.Services.AddTransient<ICustomerRepo, CustomerRepo>();
            builder.Services.AddTransient<ICustomerServices, CustomerServices>();
            builder.Services.AddTransient<ISupplierRepo, SupplierRepo>();
            builder.Services.AddTransient<ISupplierServices, SupplierServices>();

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
                pattern: "{controller=Login}/{action=SignIn}/{id?}");

            app.Run();
        }
    }
}