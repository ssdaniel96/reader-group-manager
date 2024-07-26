using Ioc.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediator()
    .AddDatabase(builder.Configuration)
    .AddRepositories()
    .AddMapper();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(config => config.AddDefaultPolicy(x =>
{
    x.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
}));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseCors();

app.Run();