
using _CovidXWebApp.Models;
using _CovidXWebApp.Models.Services;
using _CovidXWebApp.Models.Services.Interfaces;
using EFCORE_DATAACCESS;
using EFCORE_DATAACCESS.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Email;

namespace _CovidXWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
          
            // include database context for application
            services.AddDbContext<CovidXSQLDBContext>(option =>
            {
                // using an SQL Server connection
                option.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"],
                    b => b.MigrationsAssembly("_CovidXWebApp"));
            });

            // configures authentication to use identity cookies
            // requires nuget package 'Microsoft.AspNetCore.Identity.EntityFrameworkCore' + 'Microsoft.AspNetCore.Identity.UI'
            services.AddDefaultIdentity<CovidXUser>(options =>
            {
                // require account to sign in
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedEmail = false;
                // password requirements
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
              
                options.Password.RequireUppercase = false;
            
                
            }).AddRoles<IdentityRole>().AddEntityFrameworkStores<CovidXSQLDBContext>();
            // specify the DbContext class to use for Identity

            //Add DI for Services
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<INurseService, NurseService>();
            services.AddTransient<ITestRequestService, TestRequestService>();
            services.AddTransient<IDependentService, DependentService>();
            services.AddTransient<IEmailService, EmailService>();


            //Add DI for calender
            services.AddTransient<ICalenderService, CalenderService>();

            //Add DI for Email
            services.AddTransient<IEmailer, Emailer>();


            // add Auto Mapper service
            services.AddAutoMapper(typeof(Startup));

            services.ConfigureApplicationCookie(options =>
            {
                  options.LoginPath = "/Account/Login";
            //    options.LogoutPath = ""/Account/logout";
            //    options.AccessDeniedPath = $"/account/accessDenied";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
