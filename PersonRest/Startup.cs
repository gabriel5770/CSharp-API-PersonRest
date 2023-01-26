using PersonRest.Services;
using PersonRest.Services.Implementations;

namespace PersonRest
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            //Adiciona a Interface e a implementação
            //Injeção de dependência
            services.AddScoped<IPersonService, PersonServiceImplementation>();
        }




    }
}
