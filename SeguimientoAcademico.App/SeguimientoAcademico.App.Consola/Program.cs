using System;
using SeguimientoAcademico.App.Persistencia;
using SeguimientoAcademico.App.Dominio;
using SeguimientoAcademico.App.Persistencia.AppRepositorios;

namespace SeguimientoAcademico.App.Consola
{
    class Program
    {

        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante();
        private static IRepositorioMaestro _repoMaestro = new RepositorioMaestro();
        private static IRepositorioTutor _repoTutor = new RepositorioTutor();
        private static IRepositorioFamiliarDesignado _repoFamiliarDesignado = new RepositorioFamiliarDesignado();
        static void Main(string[] args)
        {
            Console.WriteLine("PRUEBA CRUD");
           //AddEstudiante();
           //BuscarEstudiante(1);
           //AddMaestro();
           //AddTutor();
           AddFamiliarDesignado();
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
                //MateriasInscritas="Matematicas",
                Grado="9"

            };
            _repoEstudiante.AddEstudiante(estudiante);

        }
        
        private static void AddMaestro(){
            var maestro = new Maestro{

                Nombre ="Diana",
                Apellido="Mairin",
                Telefono="582697",
                Genero =Genero.femenino,
                LicenciaProfesional="2584698",
                Especialidad="Ingeniera"
                

            };
            _repoMaestro.AddMaestro(maestro);
        }

         private static void AddTutor(){
            var tutor = new Tutor{

                Nombre ="Fernando",
                Apellido="Mendez",
                Telefono="652878",
                Genero =Genero.masculino,
                MateriaAsignada="Ingles"
                
                

            };
            _repoTutor.AddTutor(tutor);
        }

        private static void AddFamiliarDesignado(){
            var familiarDesignado = new FamiliarDesignado{

                Nombre ="Albeiro",
                Apellido="Morales",
                Telefono="310456789",
                Genero =Genero.masculino,
                Parentesco="Padre"
                
                

            };
            _repoFamiliarDesignado.AddFamiliarDesignado(familiarDesignado);
        }


        
        private static void BuscarEstudiante(int idEstudiante)
        {
            var estudiante =_repoEstudiante.GetEstudiante(idEstudiante);
            Console.WriteLine(estudiante.Nombre+" "+ estudiante.Apellido);
        }
    }
}
