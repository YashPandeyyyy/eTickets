var builder = WebApplication.CreateBuilder(args);

// Use Startup class
var startup = new Startup(builder.Configuration);

// Call ConfigureServices manually
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Call Configure manually
startup.Configure(app, app.Environment);

app.Run();
