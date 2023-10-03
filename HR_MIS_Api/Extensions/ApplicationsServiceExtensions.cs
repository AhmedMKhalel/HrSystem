using HR_MIS_Api.Helper;
using Microsoft.AspNetCore.Mvc;

namespace HR_MIS_Api.Extensions
{
    //All Application DI Goes Here
    public static class ApplicationsServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(MappingProfiles));          
            return services;
        }

    }
}
