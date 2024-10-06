

using BusinessLayer.Manager;
using BusinessLayer.ViewModels.AutoMapperProfile;
using DataAccessLayer.Repositories.DoctorRepo;
using day2withDB.Data.Context.DAL;
using Microsoft.EntityFrameworkCore;
using System;

namespace day2withDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<WebAppContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

            builder.Services.AddScoped<IDoctorRepo,DoctorRepo>();
            builder.Services.AddScoped<IDoctorManager,DoctorManager>();
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

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

            app.Run();
        }
    }
}
