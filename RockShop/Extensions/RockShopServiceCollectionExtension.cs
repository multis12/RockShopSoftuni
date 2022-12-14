using RockShop.Core.Contracts;
using RockShop.Core.Services;
using RockShop.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RockShopServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}
