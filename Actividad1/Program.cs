using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

/* 
    Universidad Tecnológica Metropolitana
    Aplicaciones Web Orientadas a Objetos
    Docente: Chuc Uc Joel Ivan
    Actividad: Actividad 1
    Alumno: Daniel Francisco Puch Ceballos
    Cuatrimestre: 4
    Parcial: 1
    Grupo: A
*/

namespace Actividad1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
