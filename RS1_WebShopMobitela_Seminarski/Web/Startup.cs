using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using ServiceLayer;
using Microsoft.AspNetCore.Identity;
using DataAccessLayer;
using ServiceLayer.Interfaces;
using ServiceLayer.Classes;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ServiceLayer.Classes.Helper;

namespace Web
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
            services.AddDbContext<ApplicationContext>(options => options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationContext>();

            //register services
            services.AddTransient<IMobitelService, MobitelService>();
            services.AddTransient<IGradoviService, GradoviService>();
            services.AddTransient<IKupacService, KupacService>();
            services.AddTransient<IKomentarService, KomentarService>();
            services.AddTransient<INovostiService, NovostiService>();
            services.AddTransient<INarudzbaService, NarudzbaService>();
            services.AddTransient<IProizvodjacService, ProizvodjacService>();
            services.AddTransient<ILogService, LogService>();
            services.AddTransient<ISmsService, SmsService>();
            services.AddTransient<IEmailService, EmailService>();

            // add our mail settings
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.Configure<SmsSettings>(Configuration.GetSection("SmsSettings"));

            services.AddMvc();
            services.AddSession();
            services.AddHttpContextAccessor();


            services.AddIdentityCore<ApplicationUser>()
               .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<ApplicationContext>()
               .AddSignInManager()
               .AddDefaultTokenProviders();

           

            services.AddAuthentication(o =>
            {
                o.DefaultScheme = IdentityConstants.ApplicationScheme;
                o.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                o.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                o.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;

            })
            .AddIdentityCookies(o => { });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // custom exception handler for logging our users potential exceptions.
                app.UseExceptionHandler("/Customer/Customer/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseSession();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                   name: "Customer",
                   pattern: "{area=Customer}/{controller=Customer}/{action=Index}/{id?}");

               
            });
        }
    }
}
