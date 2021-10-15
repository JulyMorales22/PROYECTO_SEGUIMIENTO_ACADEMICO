using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using SeguimientoAcademico.App.Persistencia;


namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioSugerencia : IRepositorioSugerencia
    {
        private readonly AppContext _appContext = new AppContext();
       
        

        Sugerencia IRepositorioSugerencia.AddSugerencia(Sugerencia sugerencia){
           var SugerenciaAdicionada = _appContext.Sugerencias.Add(sugerencia);
           _appContext.SaveChanges();
           return SugerenciaAdicionada.Entity; 

        }

        Sugerencia IRepositorioSugerencia.UpdateSugerencia(Sugerencia sugerencia){
            var SugerenciaEncontrada = _appContext.Sugerencias.FirstOrDefault(p => p.Id ==  sugerencia.Id);
            if (SugerenciaEncontrada!=null)
            
            {
               SugerenciaEncontrada.Descripcion=sugerencia.Descripcion;
               
               
               
               
               _appContext.SaveChanges();
            }return SugerenciaEncontrada;

              
        }

        void IRepositorioSugerencia.DeleteSugerencia(int IdSugerencia){
            var SugerenciaEncontrada = _appContext.Sugerencias.FirstOrDefault(p => p.Id == IdSugerencia);
            if(SugerenciaEncontrada==null)
            
               return;
            _appContext.Sugerencias.Remove(SugerenciaEncontrada);
            _appContext.SaveChanges();
        }

        Sugerencia IRepositorioSugerencia.GetSugerencia(int IdSugerencia){
            var SugerenciaEncontrada = _appContext.Sugerencias.FirstOrDefault(p => p.Id == IdSugerencia);
            return SugerenciaEncontrada;

        }

        IEnumerable<Sugerencia> IRepositorioSugerencia.GetAllSugerencia(){
            return _appContext.Sugerencias;
        }


    }
}