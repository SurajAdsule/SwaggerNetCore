using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.Configuration;
using WebApplication1.wwwRoot;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Reflection;

namespace WebApplication1
{
    public class Startup
    {
        private IConfiguration _config;
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //    {
            //        options.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidateIssuer = true,
            //            ValidateAudience = true,
            //           // ValidateLifetime = true,
                        
            //            //ValidateIssuerSigningKey = true,
            //            ValidIssuer = Configuration["MboAuthJwt:Issuer"],
            //            ValidAudience = Configuration["MboAuthJwt:Audience"],
            //            IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(Configuration["MboAuthJwt:Key"]))
            //        };
            //    });

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Info
            //    {
            //        Version = "v1",
            //        Title = "MyAPI-v1",
            //        Description = "Description of API-v1" ,
            //        //licence
            //        //TermsOfService
            //        //Extensions
            //    });

            //    c.SwaggerDoc("v2", new Info
            //    {
            //        Version = "v2",
            //        Title = "MyAPI-v2",
            //        Description = "Description of API-v2",
            //        //licence
            //        //TermsOfService
            //        //Extensions
            //    });
                
            //    c.AddSecurityDefinition("Bearer", new ApiKeyScheme
            //    {
            //        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
            //        Name = "Authorization",
            //        In = "header",
            //        Type = "apiKey"
            //    });

            //    c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
            //    {
            //        { "Bearer", new[] { Configuration["MboAuthJwt:Audience"] } }
            //    });

            //    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
            //    c.IncludeXmlComments(string.Format(@"{0}\{1}", System.AppDomain.CurrentDomain.BaseDirectory, xmlfile));


                
            //});

            //versioning
            //services.AddMvc(x => x.Conventions.Add(new ApiExplorerVersionConvention()));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions();
                developerExceptionPageOptions.SourceCodeLineCount = 10;
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            }
           
            app.UseHttpsRedirection();

            //This line enables the app to use Swagger, with the configuration in the ConfigureServices method.
            // app.UseSwagger();

            //This line enables Swagger UI, which provides us with a nice, simple UI with which we can view our API calls.
            //app.UseSwaggerUI(c =>
            //{
            //    //c.SwaggerEndpoint("/swagger/v1/swagger.json","MyAPI");
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"v1");
            //    c.SwaggerEndpoint("/swagger/v2/swagger.json", $"v2");
            //});

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
