using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => o.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddSingleton<LogisPe.Api.IAM.AuthService>();
builder.Services.AddSingleton<LogisPe.Api.Users.UsersService>();
builder.Services.AddSingleton<LogisPe.Api.Stocks.StocksService>();
builder.Services.AddSingleton<LogisPe.Api.Orders.OrdersService>();
builder.Services.AddSingleton<LogisPe.Api.Suppliers.SuppliersService>();
builder.Services.AddSingleton<LogisPe.Api.Stores.StoresService>();

var app = builder.Build();
app.UseCors();
app.UseSwagger();
app.UseSwaggerUI(o => { o.RoutePrefix = "docs"; o.SwaggerEndpoint("/swagger/v1/swagger.json", "LogisPe API v1"); });
app.MapGet("/health", () => Results.Json(new { status = "ok" }));
app.MapControllers();

app.Run();