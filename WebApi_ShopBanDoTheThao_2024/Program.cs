using Microsoft.OpenApi.Models;
using System.Data.Entity;

using WebApi_ShopBanDoTheThao_2024.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi_ShopBanDoTheThao_2024.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebApi_ShopBanDoTheThao_2024Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApi_ShopBanDoTheThao_2024Context") ?? throw new InvalidOperationException("Connection string 'WebApi_ShopBanDoTheThao_2024Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<TodoContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ToDo API",
        Description = "An ASP.NET Core Web API for managing ToDo items",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty; // Phục vụ Swagger UI tại root của ứng dụng
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
