using Microsoft.EntityFrameworkCore;
using wholesale_retail_store.Application;
using wholesale_retail_store.Infrastructure;
using wholesale_retail_store.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
Console.WriteLine("Below here ");
builder.Services.AddApplicationExtensions();
builder.Services.AddInfrastructureExtensions();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(MediatrEntryPoint).Assembly));



builder.Services.AddDbContext<AppDbContext>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); 
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tracker API v1");
        c.RoutePrefix = string.Empty;
    });
}


app.UseRouting();  
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); // Map controller routes

app.Run();