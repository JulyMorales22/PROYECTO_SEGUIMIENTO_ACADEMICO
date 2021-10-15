using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using SeguimientoAcademico.App.Persistencia;


namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
         private readonly AppContext _appContext = new AppContext();
      
        

        Maestro IRepositorioMaestro.AddMaestro(Maestro maestro){
           var maestroAdicionado = _appContext.Maestros.Add(maestro);
           _appContext.SaveChanges();
           return maestroAdicionado.Entity; 

        }

        Maestro IRepositorioMaestro.UpdateMaestro(Maestro maestro){
            var maestroEncontrado = _appContext.Maestros.FirstOrDefault(p => p.Id ==  maestro.Id);
            if (maestroEncontrado!=null)
            
            {
               maestroEncontrado.Nombre=maestro.Nombre;
               maestroEncontrado.Apellido=maestro.Apellido;
               maestroEncontrado.Telefono=maestro.Telefono;
               maestroEncontrado.Genero=maestro.Genero;
               maestroEncontrado.LicenciaProfesional=maestro.LicenciaProfesional;
               maestroEncontrado.Especialidad=maestro.Especialidad;
               

               _appContext.SaveChanges();
            }return maestroEncontrado;

              
        }

        void IRepositorioMaestro.DeleteMaestro(int IdMaestro){
            var maestroEncontrado = _appContext.Maestros.FirstOrDefault(p => p.Id == IdMaestro);
            if(maestroEncontrado==null)
            
               return;
            _appContext.Maestros.Remove(maestroEncontrado);
            _appContext.SaveChanges();
        }

        Maestro IRepositorioMaestro.GetMaestro(int IdMaestro){
            var maestroEncontrado = _appContext.Maestros.FirstOrDefault(p => p.Id == IdMaestro);
            return maestroEncontrado;

        }

        IEnumerable<Maestro> IRepositorioMaestro.GetAllMaestro(){
            return _appContext.Maestros;
        }
    }
}