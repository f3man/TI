
    // Authorization: custom KcDyeD01iC4J5YyXSBbglKAdQhFQlM2n8TWOrQ9HVgk=:1680979196
    
    
    // HealthController.cs
    [ApiController]
    [Route("health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("ping")]
        public IActionResult Ping()
        {
            return Ok();
        }
    }

    #region Program.cs
    public class Program
    {
        public static int Main(string[] args)
        {
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
    #endregion

    #region Startup.cs
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //..
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //..
        }
    }
    #endregion
