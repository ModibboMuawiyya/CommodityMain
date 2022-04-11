using CommodityMain.DataAccess.EF;
using CommodityMain.Domain.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace CommodityMain
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
            //services.AddDbContextPool<CommodityContext>(
            //        options => options.UseMySql(Configuration.GetConnectionString("DBConn"),                    
            //            ServerVersion.AutoDetect("DBConn"),
            //        options => options.EnableRetryOnFailure(
            //            maxRetryCount: 5,
            //            maxRetryDelay: System.TimeSpan.FromSeconds(30),
            //            errorNumbersToAdd: null)
            //    ));
            //services.AddDbContext<CommodityContext>(options => options.UseMySql(Configuration.GetConnectionString("DBConn"),
            //    mysqlOptions =>
            //    {
            //        mysqlOptions.ServerVersion(new System.Version(5, 7, 14),
            //            Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MySql);
            //    }));

            services.AddDbContext<CommodityContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DBConn"),
                    ServerVersion.Parse("5.1.1"));
            });

            // Enable Cors
            services.AddCors(c =>
               {
                   c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
               });

            services.AddControllers();
            services.AddBLDependenciesLibraries();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CommodityMain", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable Cors
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CommodityMain v1"));
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
