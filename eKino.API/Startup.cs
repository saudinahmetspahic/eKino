using AutoMapper;
using eKino.API.Controllers;
using eKino.API.Database;
using eKino.API.EF;
using eKino.API.Services;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;


using System.Collections.Generic;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;

namespace eKino.API
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
            services.AddControllers();

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "eKino API", Version = "v1" });

            //    // basic auth swagger
            //    c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
            //    {
            //        Name = "Authorization",
            //        Type = SecuritySchemeType.Http,
            //        Scheme = "basic",
            //        In = ParameterLocation.Header,
            //        Description = "Basic Authorization header using the Bearer scheme."
            //    });

            //    c.AddSecurityRequirement(new OpenApiSecurityRequirement
            //    {
            //        {
            //            new OpenApiSecurityScheme
            //            {
            //                Reference = new OpenApiReference
            //                {
            //                    Type = ReferenceType.SecurityScheme,
            //                    Id = "basic"
            //                }
            //            },
            //            new string[] {}
            //        }
            //    });
            //});

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<IFilmService, FilmService>();
            services.AddScoped<IGradService, GradService>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IUlogaService, UlogaService>();
            services.AddScoped<IOcijenaService, OcijenaService>();
            services.AddScoped<IPaketService, PaketService>();
            services.AddScoped<IRezervacijaService, RezervacijaService>();
            services.AddScoped<IKomentarService, KomentarService>();
            services.AddScoped<IKomentarReakcijaService, KomentarReakcijaService>();

            services.AddScoped<IService<Model.Ocijena, OcijenaSearchRequest>, OcijenaService>();
            services.AddScoped<IService<Model.Paket, KorisnikPaketSearchRequest>, PaketService>();
            services.AddScoped<IService<Model.Korisnik, KorisnikSearchRequest>, KorisnikService>();
            services.AddScoped<ICRUDService<Model.Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikInsertRequest>, KorisnikService>();

            services.AddDbContext<MojContext>(option => option.UseSqlServer(Configuration.GetConnectionString("connectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }
    }
}
