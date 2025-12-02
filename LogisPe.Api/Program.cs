using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod());
});

builder.Services.AddSingleton<LogisPe.Api.IAM.AuthService>();
builder.Services.AddSingleton<LogisPe.Api.Users.UsersService>();
builder.Services.AddSingleton<LogisPe.Api.Stocks.StocksService>();
builder.Services.AddSingleton<LogisPe.Api.Orders.OrdersService>();
builder.Services.AddSingleton<LogisPe.Api.Suppliers.SuppliersService>();
builder.Services.AddSingleton<LogisPe.Api.Stores.StoresService>();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

var app = builder.Build();

app.UseCors();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.RoutePrefix = "docs";
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "LogisPe API v1");
});

app.MapGet("/", () => Results.Json(new { status = "LogisPe API running" }));
app.MapGet("/health", () => Results.Json(new { status = "ok" }));

app.MapControllers();

app.Run();
