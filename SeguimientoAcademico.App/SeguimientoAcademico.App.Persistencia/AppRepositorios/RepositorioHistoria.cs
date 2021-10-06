using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using SeguimientoAcademico.App.Persistencia;


namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioHistoria :IRepositorioHistoria
    {
        private readonly SeguimientoAcademico.App.Persistencia.AppContext _appContext;
        public RepositorioHistoria(SeguimientoAcademico.App.Persistencia.AppContext appContext){
        _appContext=appContext;
        }
        

        Historia IRepositorioHistoria.AddHistoria(Historia historia){
           var HistoriaAdicionada = _appContext.Historias.Add(historia);
           _appContext.SaveChanges();
           return HistoriaAdicionada.Entity; 

        }

        Historia IRepositorioHistoria.UpdateHistoria(Historia historia){
            var HistoriaEncontrada = _appContext.Historias.FirstOrDefault(p => p.Id ==  historia.Id);
            if (HistoriaEncontrada!=null)
            
            {
               HistoriaEncontrada.Tarea=historia.Tarea;
               HistoriaEncontrada.Calificacion=historia.Calificacion;
               HistoriaEncontrada.Id_Maestro=historia.Id_Maestro;
               HistoriaEncontrada.Estado=historia.Estado;
               HistoriaEncontrada.Sugerencia=historia.Sugerencia;
               
               
               _appContext.SaveChanges();
            }return HistoriaEncontrada;

              
        }

        void IRepositorioHistoria.DeleteHistoria(int IdHistoria){
            var HistoriaEncontrada = _appContext.Historias.FirstOrDefault(p => p.Id == IdHistoria);
            if(HistoriaEncontrada==null)
            
               return;
            _appContext.Historias.Remove(HistoriaEncontrada);
            _appContext.SaveChanges();
        }

        Historia IRepositorioHistoria.GetHistoria(int IdHistoria){
            var HistoriaEncontrada = _appContext.Historias.FirstOrDefault(p => p.Id == IdHistoria);
            return HistoriaEncontrada;

        }

        IEnumerable<Historia> IRepositorioHistoria.GetAllHistoria(){
            return _appContext.Historias;
        }
    }
}