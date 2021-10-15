using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using SeguimientoAcademico.App.Persistencia;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
     private readonly AppContext _appContext = new AppContext();
      

        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante){
           var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
           _appContext.SaveChanges();
           return estudianteAdicionado.Entity; 

        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante){
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
               estudianteEncontrado.Familiar=estudiante.Familiar;
               
               estudianteEncontrado.Historia=estudiante.Historia;

               _appContext.SaveChanges();
            }return estudianteEncontrado;

              
        }

        void IRepositorioEstudiante.DeleteEstudiante(int Idestudiante){
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == Idestudiante);
            if(estudianteEncontrado==null)
            
               return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int Idestudiante){
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == Idestudiante);
            return estudianteEncontrado;

        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiante(){
            return _appContext.Estudiantes;
        }
    }
}