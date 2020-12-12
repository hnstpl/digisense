using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using ServiceHistory.WebAPI.Helpers;
using ServiceHistoryMaster.WebAPI.DataProvider;
using ServiceHistoryMaster.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHistory.WebAPI
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
            var DBUsername = Configuration["DBUsername"];
            var DBPassword = Configuration["DBPassword"];
            var Database = Configuration["Database"];
            var DBServer = Configuration["Server"];

            StringBuilder Connectionstring = new StringBuilder();

            //Build database connectionstring
            Connectionstring.Append("server=");
            Connectionstring.Append(DBServer);
            Connectionstring.Append(";port=3306");
            Connectionstring.Append(";user=");
            Connectionstring.Append(DBUsername);
            Connectionstring.Append(";password=");
            Connectionstring.Append(DBPassword);
            Connectionstring.Append(";database=");
            Connectionstring.Append(Database);

            //Register Data connext
            services.AddDbContext<dev_encrypted_generalcustomerappContext>(
                options =>
                options.UseMySQL(Connectionstring.ToString())
                );


            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            });


            services.AddTransient<IServiceHistoryService, ServiceHistoryService>();
            services.AddTransient<IGlobalService, GlobalService>();

            services.AddDistributedMemoryCache();
            services.AddSession();

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

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=ServiceHistory}/{action=Get_ServiceHistory}/{id?}");
            });

            //For session
            app.UseSession();
        }
    }
}
