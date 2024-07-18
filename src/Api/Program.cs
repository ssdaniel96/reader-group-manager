using Ioc.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediator()
    .AddDatabase(builder.Configuration)
    .AddRepositories()
    .AddMapper();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();