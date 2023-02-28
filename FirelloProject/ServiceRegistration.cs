using FirelloProject.DAL;
using FirelloProject.Services.Basket;
using Microsoft.EntityFrameworkCore;

namespace FirelloProject
{
    public static class ServiceRegistration
    {
        public static void FirelloServiceRegistration(this IServiceCollection services)
        {
          
            services.AddHttpContextAccessor();

            services.AddScoped<IBasketProductCount, BasketProductCount>();

        } 
    }
}

