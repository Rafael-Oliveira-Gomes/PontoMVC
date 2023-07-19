using LRSV1.Interface.Repository;
using LRSV1.Repository;

namespace LRSV1.Config.Ioc
{
    public static class RepositoryIoc
    {
        public static void ConfigRepositoryIoc(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPontoRepository, PontoRepository>();
        }
    }
}