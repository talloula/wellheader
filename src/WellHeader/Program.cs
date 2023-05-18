using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WellHeader.Controllers;
using WellHeader.Repositories;
using WellHeader.Interfaces;
using WellHeader.DAL;
using WellHeader.Services;

namespace WellHeader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IWellRepository, WellRepository>();
            builder.Services.AddScoped<IWellService, WellService>();

            builder.Services.AddDbContext<WellheaderDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConncetion"));
            });
            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

           

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

                     //   app.MapFieldEndpoints();

            app.Run();
        }
    }
}