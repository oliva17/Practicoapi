﻿using PracticaApi.Business.Clases;
using PracticaApi.Business.Contracts;
using PracticaApi.Services.Clases;
using PracticaApi.Services.Contracts;

namespace PracticaApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }    
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddResponseCaching();
            services.AddTransient<IRolService, RolService>();
            services.AddTransient<IRolRepository, RolRepository>();
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI
            // at https://aka.ms/aspnetcore/swashbuckle

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

           

        }
    }


}
