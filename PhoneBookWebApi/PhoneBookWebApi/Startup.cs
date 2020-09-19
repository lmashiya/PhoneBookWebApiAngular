using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using PhoneBookWebApi.Models;

namespace PhoneBookWebApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(option =>
            {
                var contractResolver = option.SerializerSettings.ContractResolver;
                if (contractResolver != null)
                {
                    (contractResolver as DefaultContractResolver).NamingStrategy = null;
                }
            });
            
            services.AddDbContext<PhoneBookContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("WebApiConnection")));

            services.AddCors();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0.0.0", new OpenApiInfo
                {
                    Version = "v1.0.0.0",
                    Title = "Simple PhoneBook API",
                    Description = "CRUD operations on a contact",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Lehlohonolo Mashiyane",
                        Email = "LehlohonoloMashiyane@gmail.com",
                        Url = new Uri("https://github.com/lmashiya"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX...Joking use at own risk",
                        Url = new Uri("https://example.com/license"),
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0.0.0/swagger.json", "PhoneBook API V1");
            });

            //if (env.IsDevelopment())
            //{
                app.UseDeveloperExceptionPage();
            //}

            app.UseCors(options => options.WithOrigins("http://localhost:4200/").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());

            app.UseMvc();

            
        }
    }
}
