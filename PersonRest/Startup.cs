using Microsoft.EntityFrameworkCore;
using PersonRest.Model.Context;
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

          
             // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(7, 0, 0))));
            //Injeção de dependência
            services.AddScoped<IPersonService, PersonServiceImplementation>();

        }

        public void Configure(WebApplication app, IWebHostEnvironment enviroment)
        {

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

        }




    }
}
