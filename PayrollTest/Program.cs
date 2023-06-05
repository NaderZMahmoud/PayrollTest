using PayrollTest.API.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using PayrollTest.API.Models;
using Microsoft.Extensions.Configuration;

internal class Program
{
   
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
       
        builder.Services.AddDbContext<PayrollDBContext>(options => options.UseInMemoryDatabase("PayrollDb"));
        builder.Services.AddAutoMapper(options => options.AddProfile<MappingProfile>());
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowMyApp", policy =>
            {
                policy.AllowAnyOrigin();
            });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors("AllowMyApp");
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}