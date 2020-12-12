using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.DataProvider;
using TractorMasters.WebAPI.Services;

namespace TractorMasters.WebAPI
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
            services.AddDbContext<dev_encrypted_generalcustomerappContext>(option => option.UseMySQL("server=192.168.1.101;port=3306;user=GenCusApp;password=HnS@2016;database=dev_encrypted_generalcustomerapp"));

            services.AddTransient<IGlobalService, GlobalService>();
            services.AddTransient<IProductMasterInfoService, ProductMasterInfoService>();            
            services.AddTransient<ITractorModelsService, TractorModelsService>();
            services.AddTransient<ITSpecificationCategoryMasterService, TSpecificationCategoryMasterService>();
            services.AddTransient<ITSpecificationMasterService, TSpecificationMasterService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
