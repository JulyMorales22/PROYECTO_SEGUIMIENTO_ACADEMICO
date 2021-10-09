using System;
using SeguimientoAcademico.App.Persistencia;
using SeguimientoAcademico.App.Dominio;
using SeguimientoAcademico.App.Persistencia.AppRepositorios;

namespace SeguimientoAcademico.App.Consola
{
    class Program
    {

        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante();
        static void Main(string[] args)
        {
            Console.WriteLine("PRUEBA CRUD");
           //AddEstudiante();
           //BuscarEstudiante(1);
        }

        private static void AddEstudiante(){
            var estudiante = new Estudiante
            { 
                Nombre="Jimmy",
                Apellido="Sarmiento",
                Telefono="8631467",
                Genero=Genero.masculino,
                Direccion="call 18",
                Latitud=18.92F,
                Longitud=-89.009F,
                Ciudad="Cucuta",
                MateriasInscritas="Matematicas",
                Grado="9"

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
