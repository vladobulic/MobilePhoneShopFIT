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
using Microsoft.AspNetCore.Mvc;

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

            //services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

           // services.BuildServiceProvider().GetService<ApplicationContext>().Database.Migrate();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            // .AddEntityFrameworkStores<ApplicationContext>();


           
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
            services.AddTransient<IPopustiService, PopustiService>();
            services.AddTransient<IZupanijaService, ZupanijaService>();
            services.AddTransient<IDobavljacService, DobavljacService>();
            services.AddTransient<IKomponenteService, KomponenteService>();
            services.AddTransient<ITipKomponenteService, TipKomponenteService>();
            services.AddTransient<IStavkeNarudzbeService, StavkeNarudzbeService>();
            services.AddTransient<ISlikaService, SlikaService>();
            services.AddTransient<IAdministratorService, AdministratorService>();
            services.AddTransient<IServisService, ServisService>();
            services.AddTransient<IStavkaServisService, StavkaServisService>();
            services.AddTransient<IZaposlenikService, ZaposlenikService>();
            services.AddTransient<IBannedKupacService, BannedKupacService>();
            services.AddTransient<IPorukaService, PorukaService>();


            // add our mail settings
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            //services.Configure<SmsSettings>(Configuration.GetSection("SmsSettings"));



            services.AddMvc();
            services.AddSession();
            services.AddHttpContextAccessor();
            //options =>
            //{
            //    options.SignIn.RequireConfirmedEmail = true;
            //}

            services.AddIdentityCore<ApplicationUser>()
               .AddRoles<IdentityRole>()
               .AddSignInManager()
               .AddEntityFrameworkStores<ApplicationContext>()
               .AddDefaultTokenProviders();


            //services.AddIdentityCore<ApplicationUser>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = true;

            //})
            //   .AddRoles<IdentityRole>()
            //   .AddSignInManager()
            //   .AddEntityFrameworkStores<ApplicationContext>()
            //   .AddDefaultTokenProviders();
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            

            services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
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
                options.LoginPath = $"/Admin/Account/Login";
                options.LogoutPath = $"/Admin/Account/Logout";
                options.AccessDeniedPath = $"/Admin/Account/AccessDenied";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseExceptionHandler("/Admin/Account/Error");
            }
            else
            {
                // custom exception handler for logging our users potential exceptions.
                //app.UseExceptionHandler("/Customer/Customer/Error").
                   app.UseExceptionHandler("/Admin/Account/Error");
                app.UseHsts();
            }
          
            app.UseHttpsRedirection();
            app.UseSession();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            //ApplicationDbInitializer.SeedUsers(userManager, context);

            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}");

                //app.UseEndpoints(endpoints =>
                //{
                //    endpoints.MapControllerRoute(
                //        name: "default",
                //        pattern: "{controller=Sms}/{action=Index}/{id?}");
                //});

                endpoints.MapControllerRoute(
                   name: "Customer",
                   pattern: "{area=Customer}/{controller=Customer}/{action=Index}/{id?}");

               
            });
        }
    }
}
