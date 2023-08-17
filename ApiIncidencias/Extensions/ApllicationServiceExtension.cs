
using Aplicacion.UnitOfWork;
using Dominio.Interfaces;

namespace ApiIncidencias.Extensions;
    public static class ApllicationServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options => 
            {
                options.AddPolicy("CorsPolicy",builder=>
                    builder.AllowAnyOrigin()        //WithOrigins("http://domini.com")
                    .AllowAnyMethod()               //WithMethods(*GET", "POST")
                    .AllowAnyHeader());             //WithHeaders(*accept*, "content-type")
            });


        public static void AddAplicacionServices(this IServiceCollection services){
            services.AddScoped<IUnitOfWork,UnitOfWork>();
        }
        
    }
