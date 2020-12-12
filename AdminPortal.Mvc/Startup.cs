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
using Microsoft.AspNetCore.Http;
using AdminPortal.Mvc.Services;
using AdminPortal.Mvc.DataProvider;
using Microsoft.EntityFrameworkCore;

namespace AdminPortal.Mvc
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
            services.AddSession(s => s.IdleTimeout = TimeSpan.FromMinutes(30));

            services.AddDbContext<dev_encrypted_generalcustomerappContext>(option => option.UseMySQL("server=192.168.1.101;port=3306;user=udhayakumarm;password=Pwd08uk2020;database=dev_encrypted_generalcustomerapp"));

            // This is the line for integrating services for implementation classes
            services.AddTransient<IGlobalService, GlobalService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMenuViewService, MenuViewService>();
            services.AddTransient<IGeoLocationService, GeoLocationService>();
            services.AddTransient<IDealerService, DealerService>();
            services.AddTransient<IManufacturerService, ManufacturerService>();
            services.AddTransient<ISpecificationCategoryService, SpecificationCategoryService>();
            services.AddTransient<IVideoCategoryService, VideoCategoryService>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<IHPService, HPService>();
            services.AddTransient<ITipofCatgeoryService, TipofCatgeoryService>();
            services.AddTransient<ITipoftheDay, AdminPortal.Mvc.Services.TipoftheDay>();
            services.AddTransient<IImplementModelService, ImplementModelService>();
            services.AddTransient<ITractorModelGroupService, TractorModelGroupService>();
            services.AddTransient<ITractorModelService, TractorModelService>();
            services.AddTransient<IImplementModelGroupService, ImplementModelGroupService>();
            services.AddTransient<IDIYService, DIYService>();
            services.AddTransient<IBannerNotificationService, BannerNotificationService>();
            services.AddTransient<IImplementSuitability, ImplementSuitabilityService>();
            services.AddTransient<IImplementsService, ImplementsService>();
            services.AddTransient<IImplements, ImplementService>();
            services.AddTransient<ITractorsService, TractorsService>();
            services.AddTransient<IDIYService, DIYService>();
            services.AddTransient<ICropsService, CropsService>();
            services.AddTransient<IMandiService, MandiService>();
            services.AddTransient<IEnquiry, EnquiryService>();
            services.AddTransient<IOldTractorEvaluation, OldTractorEvaluationService>();

            services.AddControllersWithViews();

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.Use(async (context, next) =>
            {
                string User = context.Session.GetString("MenuMaster");
                if (!context.Request.Path.Value.Contains("/Account/Login") && context.Request.Method == "GET")
                {
                    if (string.IsNullOrEmpty(User))
                    {
                        var path = $"/Account/Login?ReturnUrl={context.Request.Path}";
                        context.Response.Redirect(path);
                        return;
                    }
                }
                await next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
