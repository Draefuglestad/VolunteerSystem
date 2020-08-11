using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VolunteerSystem.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace VolunteerSystem
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        IConfigurationRoot Configuration; 
        public Startup(IWebHostEnvironment env) 
        { 
            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        { //services.AddTransient<IProductRepository, FakeProductRepository>(); 
            services.AddTransient<IOpportunityRepository, FakeOpportunityRepository>();

            services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); 
            services.AddTransient<IVolunteerRepository, EFVolunteerRepository>();
            services.AddTransient<IOpportunityRepository, EFOpportunityRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); 
            services.AddIdentity<AppUser, IdentityRole<Guid>>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMemoryCache(); services.AddSession();

        }




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory) 
        { 
            app.UseDeveloperExceptionPage(); 
            app.UseStatusCodePages(); 
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "pagination", 
                    template: "Volunteers/Page{page}", 
                    defaults: new { Controller = "Volunteer", action = "List" }); 

                routes.MapRoute(
                    name: "default", 
                    template: "{controller=Volunteer}/{action=VolunteerList}/{id?}");

                routes.MapRoute(
                name: null,
                template: "Page{page:int}",
                defaults: new { controller = "Opportunity", action = "List", page = 1 }
                );



            });

        }
    }
}
