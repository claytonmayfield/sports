using Microsoft.EntityFrameworkCore;

namespace Assigment3_1.Models
{
    public class StartUp
    {
        public StartUp(IConfiguration configuration)
        {

            Configuration = configuration;

        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<SportsProContext>(options => options.
            UseSqlServer(Configuration.GetConnectionString("SportsPro"),
            sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 10,
                maxRetryDelay: TimeSpan.FromSeconds(5),
                errorNumbersToAdd: null);
            }
            ));

        }
    }
}