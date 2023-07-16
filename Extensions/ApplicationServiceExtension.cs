using InvoiceAppAPI.Helper;
using InvoiceAppAPI.Repositories;
using Microsoft.OpenApi.Models;

using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace InvoiceAppAPI.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            // Register db connetion to DI
            services.AddScoped<IDbConnection>(db =>
                new SqlConnection(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            // Register CORS
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policyBuilder => policyBuilder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });


            return services;
        }
    }
}
