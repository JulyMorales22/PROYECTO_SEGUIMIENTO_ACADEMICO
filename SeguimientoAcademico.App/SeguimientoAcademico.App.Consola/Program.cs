using System;
using SeguimientoAcademico.App.Persistencia;
using SeguimientoAcademico.App.Dominio;
using SeguimientoAcademico.App.Persistencia.AppRepositorios;

namespace SeguimientoAcademico.App.Consola
{
    class Program
    {

        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("PRUEBA CRUD");
           // AddEstudiante();
           BuscarEstudiante(1);
        }

        private static void AddEstudiante(){
            var estudiante = new Estudiante
            { 
                Nombre="July",
                Apellido="Morales",
                Telefono="3583862",
                Genero=Genero.femenino,
                Direccion="cra 13",
                Latitud=18.92F,
                Longitud=-89.009F,
                Ciudad="Caucasia",
                MateriasInscritas="Matematicas",
                Grado="6"

            };
            _repoEstudiante.AddEstudiante(estudiante);

        }
        
        private static void BuscarEstudiante(int idEstudiante)
        {
            var estudiante =_repoEstudiante.GetEstudiante(idEstudiante);
            Console.WriteLine(estudiante.Nombre+" "+ estudiante.Apellido);
        }
    }
}
