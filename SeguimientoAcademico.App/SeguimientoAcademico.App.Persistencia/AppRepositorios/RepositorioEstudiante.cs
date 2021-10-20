using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using SeguimientoAcademico.App.Persistencia;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly AppContext _appContext = new AppContext();


        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;

        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == estudiante.Id);
            if (estudianteEncontrado != null)

            {
                estudianteEncontrado.Nombre = estudiante.Nombre;
                estudianteEncontrado.Apellido = estudiante.Apellido;
                estudianteEncontrado.Telefono = estudiante.Telefono;
                estudianteEncontrado.Genero = estudiante.Genero;
                estudianteEncontrado.MateriasInscritas = estudiante.MateriasInscritas;
                estudianteEncontrado.Grado = estudiante.Grado;
                estudianteEncontrado.Direccion = estudiante.Direccion;
                estudianteEncontrado.Latitud = estudiante.Latitud;
                estudianteEncontrado.Longitud = estudiante.Longitud;
                estudianteEncontrado.Ciudad = estudiante.Ciudad;
                estudianteEncontrado.NombreFamiliar = estudiante.NombreFamiliar;
                estudianteEncontrado.TelefonoFamiliar = estudiante.TelefonoFamiliar;
                estudianteEncontrado.ParentescoFamiliar = estudiante.ParentescoFamiliar;



                _appContext.SaveChanges();
            }
            return estudianteEncontrado;


        }

        void IRepositorioEstudiante.DeleteEstudiante(int Idestudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == Idestudiante);
            if (estudianteEncontrado == null)

                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int Idestudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == Idestudiante);
            return estudianteEncontrado;

        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiante()
        {
            return _appContext.Estudiantes;
        }

        void IRepositorioEstudiante.AddHistoria(int IdEstudiante, Historia historia)
        {
            var estudiante = _appContext.Estudiantes.Find(IdEstudiante);
            if (estudiante != null)
            {
                if (estudiante.Historia != null)
                {
                    estudiante.Historia.Add(historia);
                }
                else
                {
                    estudiante.Historia = new List<Historia>();
                    estudiante.Historia.Add(historia);
                }
                var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == estudiante.Id);
                if (estudianteEncontrado != null)

                {
                    estudianteEncontrado.Nombre = estudiante.Nombre;
                    estudianteEncontrado.Apellido = estudiante.Apellido;
                    estudianteEncontrado.Telefono = estudiante.Telefono;
                    estudianteEncontrado.Genero = estudiante.Genero;
                    estudianteEncontrado.MateriasInscritas = estudiante.MateriasInscritas;
                    estudianteEncontrado.Grado = estudiante.Grado;
                    estudianteEncontrado.Direccion = estudiante.Direccion;
                    estudianteEncontrado.Latitud = estudiante.Latitud;
                    estudianteEncontrado.Longitud = estudiante.Longitud;
                    estudianteEncontrado.Ciudad = estudiante.Ciudad;
                    estudianteEncontrado.NombreFamiliar = estudiante.NombreFamiliar;
                    estudianteEncontrado.TelefonoFamiliar = estudiante.TelefonoFamiliar;
                    estudianteEncontrado.ParentescoFamiliar = estudiante.ParentescoFamiliar;



                    _appContext.SaveChanges();
                }

            }
        }

        void IRepositorioEstudiante.AddMateria(int IdEstudiante, Materia materia){

             var estudiante= _appContext.Estudiantes.Find(IdEstudiante);
            if(estudiante!=null){
                if(estudiante.MateriasInscritas!=null){
                    estudiante.MateriasInscritas.Add(materia);
                }
                else{
                    estudiante.MateriasInscritas = new List<Materia>();
                    estudiante.MateriasInscritas.Add(materia);
                }
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id ==  estudiante.Id);
            if (estudianteEncontrado!=null)
            
            {
               estudianteEncontrado.Nombre=estudiante.Nombre;
               estudianteEncontrado.Apellido=estudiante.Apellido;
               estudianteEncontrado.Telefono=estudiante.Telefono;
               estudianteEncontrado.Genero=estudiante.Genero;
               estudianteEncontrado.MateriasInscritas=estudiante.MateriasInscritas;
               estudianteEncontrado.Grado=estudiante.Grado;
               estudianteEncontrado.Direccion=estudiante.Direccion;
               estudianteEncontrado.Latitud=estudiante.Latitud;
               estudianteEncontrado.Longitud=estudiante.Longitud;
               estudianteEncontrado.Ciudad=estudiante.Ciudad;
              

               _appContext.SaveChanges();
            }
            
    }
}
    }
}
