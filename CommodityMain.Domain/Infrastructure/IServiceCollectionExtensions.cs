using CommodityAdmin;
using CommodityMain.DataAccess.EF.BaseRepos;
using CommodityMain.DataAccess.EF.Interfaces;
using CommodityMain.Domain.BL;
using CommodityMain.Domain.BL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.Infrastructure
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBLDependenciesLibraries(this IServiceCollection services)
        {
            //var mappingConfig = new MapperConfiguration(mc =>
            //{
            //    mc.AddProfile(new AutoMapperWebProfile());
            //});
            //IMapper mapper = mappingConfig.CreateMapper();


            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICommodityBL, CommodityBL>();
            services.AddScoped<ICommodityTypeBL, CommodityTypeBL>();
            services.AddScoped<ICommodityPriceBL, CommodityPriceBL>();
            services.AddScoped<ILocationBL, LocationBL>();
            services.AddScoped<IMeasurementBL, MeasurementBL>();
            services.AddScoped<IRateBL, RateBL>();
            services.AddScoped<IRateTypeBL, RateTypeBL>();

           
            return services;
        }
    }
}
