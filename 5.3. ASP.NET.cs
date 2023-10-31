
    
    // HealthController.cs
    [ApiController]
    [Route("health")]
    [Authorize(AuthenticationSchemes = "custom")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("ping")]
        [AdditionalValidation]
        public IActionResult Ping()
        {
            return Ok();
        }
    }

    #region Program & Startup
    // Program.cs
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

    // Startup.cs
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
            app.UseMiddleware<CustomMiddleware>();
            //..
        }
    }
    #endregion
    
    #region CustomAuthenticationHandler.cs
    public class CustomAuthenticationSchemeOptions : AuthenticationSchemeOptions
    {

    }
    public class CustomAuthenticationHandler : AuthenticationHandler<CustomAuthenticationSchemeOptions>
    {

        public CustomAuthenticationHandler(
            IOptionsMonitor<CustomAuthenticationSchemeOptions> options,
            ILoggerFactory logger)
            : base(options, logger)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            Console.WriteLine("CustomAuthenticationHandler: HandleAuthenticateAsync");
        }
    }
    #endregion

    #region CustomMiddleware.cs
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("CustomMiddleware: Hello from middleware!");
            await _next(context);
        }
    }
    #endregion

    #region AdditionalValidationAttribute.cs
    public class AdditionalValidationAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("AdditionalValidation: OnActionExecutionAsync");
            await base.OnActionExecutionAsync(context, next);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("AdditionalValidation: OnActionExecuted");
            base.OnActionExecuted(context);
        }
    }
    #endregion