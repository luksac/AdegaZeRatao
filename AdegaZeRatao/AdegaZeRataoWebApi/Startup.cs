using System;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace AdegaZeRataoWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddCors(option => option.AddPolicy(name: "Dominio", builder => { builder.WithOrigins("http://localhost:3000").AllowAnyOrigin(); }));
            services.AddCors(option => option.AddPolicy(name: "Dominio2", builder => { builder.WithHeaders("Origin, X-Request-Width, Content-Type, Accept ").AllowAnyHeader(); }));
            services.AddCors(option => option.AddPolicy(name: "Dominio3", builder => { builder.WithOrigins("http://localhost:3000").AllowAnyOrigin(); { builder.WithHeaders("Origin, X-Request-Width, Content-Type, Accept ").AllowAnyHeader(); } }));
            //services.AddControllers();
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Adega Zé Ratão",
                        Version = "v1",
                        Description = "API REST criada com o ASP.NET Core 3.0 para atender aplicação Front-end.",
                        Contact = new OpenApiContact
                        {
                            Name = "Lucas Araujo e Paulo Almeida",
                            Url = new Uri("https://github.com/luksac/AdegaZeRatao")
    
                        }
                    });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Adega Ze ratao");
            });
            app.UseHttpsRedirection();


            app.UseMvc();
            app.UseCors(Option => Option.AllowAnyMethod());
            app.UseCors(option => option.AllowCredentials());
            app.UseCors(option => option.AllowAnyHeader());
            app.UseCors(option => option.AllowAnyOrigin());
            app.UseCors("Dominio");
            app.UseCors("Dominio2");
            app.UseCors("Dominio3");
            

        }
    }
}
