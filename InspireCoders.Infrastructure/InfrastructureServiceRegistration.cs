using InspireCoders.Application.Contracts.FakeDataStores;
using InspireCoders.Application.Contracts.Persistence;
using InspireCoders.Infrastructure.FakeDataStores;
using InspireCoders.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InspireCoders.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<OrderContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("OrderingConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

            // services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddSingleton<IProductFakeDataStore, ProductFakeDataStore>();
            services.AddSingleton<ICourseFakeDataStore, CourseFakeDataStore>();
            services.AddSingleton<IFacilitatorFakeDataStore, FacilitatorFakeDataStore>();
            services.AddSingleton<IForumFakeDataStore, ForumFakeDataStore>();

            //services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            //services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
