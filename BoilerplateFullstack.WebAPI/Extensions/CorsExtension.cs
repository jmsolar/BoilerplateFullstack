using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BoilerplateFullstack.WebAPI.Extensions
{
    public static class CorsExtension
    {
        public static void AddCorsExtension(this IServiceCollection services, IConfiguration _conf)
        {
            services.AddCors(o => o.AddPolicy(_conf.GetSection("CorsSettings:Name").Value, builder =>
            {
                builder.WithOrigins(_conf.GetSection("CorsSettings:Origins").Value)
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
        }
    }
}
