using LRSV1.Interface.Service;
using LRSV1.Service;

namespace LRSV1.Config.Ioc
{
    public static class ServiceIoc
    {
        public static void ConfigServiceIoc(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IPontoService, PontoService>();
            services.AddHttpContextAccessor();

        }
    }
}