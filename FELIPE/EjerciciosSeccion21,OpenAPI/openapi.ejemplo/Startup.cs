using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace openapi.ejemplo
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "openapi.ejemplo", 
                                                     Version = "v1",
                                                     TermsOfService = new Uri("https://example.com/terms"),
                                                     Contact = new OpenApiContact {
                                                        Name = "Felipe Alonso",
                                                        Email = "xfelipe98@gmail.com",
                                                        Url = new Uri("https://example.com/contact"),
                                                     },
                                                     License = new OpenApiLicense {
                                                        Name = "FelipeLicense",
                                                        Url = new Uri("https://example.com/license"),
                                                     }
                });    //en swaggerDoc se puede poner tambien contacto, licencia o un link a los terminos de servicio
                //para añadir un xml file, nos vamos al proyecto y en build seleccionamos la casilla de añadir xml
                //y se añade asi:
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"; //con esto se obtiene el nombre del ensamblado .xml
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);  //coge la ruta donde esta el documento y el xmlfile que es el nombre del archivo.
                c.IncludeXmlComments(xmlPath);  //uso el middleware de incluir los comentarios xml del path donde genera esos comentarios
                //con esto ya podemos incluir comentarios con xml
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "openapi.ejemplo v1"));
            }

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
