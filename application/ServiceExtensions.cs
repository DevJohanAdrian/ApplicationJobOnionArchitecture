

using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;  //IServiceCollection
using System.Reflection; //ASSEMBLY


namespace application
{
    internal static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services) {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly()); //para CQRS
        }
    }
}
