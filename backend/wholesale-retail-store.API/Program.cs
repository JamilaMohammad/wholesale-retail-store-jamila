using Microsoft.AspNetCore.Builder;

using wholesale_retail_store.Application;
using wholesale_retail_store.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationExtensions();
builder.Services.AddInfrastructureExtensions();

var app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.EnvironmentName == "dev")
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tracker API v1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();                               // Map controller routes

app.Run();