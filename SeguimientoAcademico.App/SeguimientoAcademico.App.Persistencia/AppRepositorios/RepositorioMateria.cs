using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioMateria : IRepositorioMateria
    {
        private readonly AppContext _appContext = new AppContext();
      

        Materia IRepositorioMateria.AddMateria(Materia materia){
           var materiaAdicionada = _appContext.Materias.Add(materia);
           _appContext.SaveChanges();
           return materiaAdicionada.Entity; 

        }

        Materia IRepositorioMateria.UpdateMateria(Materia materia){
            var materiaEncontrada = _appContext.Materias.FirstOrDefault(p => p.Id ==  materia.Id);
            if (materiaEncontrada!=null)
            
            {
               materiaEncontrada.NombreMateria=materia.NombreMateria;
               materiaEncontrada.CargaHoraria=materia.CargaHoraria;
               

               _appContext.SaveChanges();
            }return materiaEncontrada;

              
        }

        void IRepositorioMateria.DeleteMateria(int Idmateria){
            var materiaEncontrada = _appContext.Materias.FirstOrDefault(p => p.Id == Idmateria);
            if(materiaEncontrada==null)
            
               return;
            _appContext.Materias.Remove(materiaEncontrada);
            _appContext.SaveChanges();
        }

        Materia IRepositorioMateria.GetMateria(int Idmateria){
            var materiaEncontrada = _appContext.Materias.FirstOrDefault(p => p.Id == Idmateria);
            return materiaEncontrada;

        }

        IEnumerable<Materia> IRepositorioMateria.GetAllMateria(){
            return _appContext.Materias;
        }
    }
}