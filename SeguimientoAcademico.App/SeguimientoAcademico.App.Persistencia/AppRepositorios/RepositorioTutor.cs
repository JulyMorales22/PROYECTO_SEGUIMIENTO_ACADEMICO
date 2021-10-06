using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using System;
using SeguimientoAcademico.App.Persistencia;


namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioTutor : IRepositorioTutor
    {
        private readonly SeguimientoAcademico.App.Persistencia.AppContext _appContext;
        public RepositorioTutor(SeguimientoAcademico.App.Persistencia.AppContext appContext){
        _appContext=appContext;
        }
        

        Tutor IRepositorioTutor.AddTutor(Tutor tutor){
           var tutorAdicionado = _appContext.Tutores.Add(tutor);
           _appContext.SaveChanges();
           return tutorAdicionado.Entity; 

        }

        Tutor IRepositorioTutor.UpdateTutor(Tutor tutor){
            var tutorEncontrado = _appContext.Tutores.FirstOrDefault(p => p.Id ==  tutor.Id);
            if (tutorEncontrado!=null)
            
            {
               tutorEncontrado.Nombre=tutor.Nombre;
               tutorEncontrado.Apellido=tutor.Apellido;
               tutorEncontrado.Telefono=tutor.Telefono;
               tutorEncontrado.Genero=tutor.Genero;
               tutorEncontrado.MateriaAsignada=tutor.MateriaAsignada;

               _appContext.SaveChanges();
            }return tutorEncontrado;

              
        }

        void IRepositorioTutor.DeleteTutor(int IdTutor){
            var tutorEncontrado = _appContext.Tutores.FirstOrDefault(p => p.Id == IdTutor);
            if(tutorEncontrado==null)
            
               return;
            _appContext.Tutores.Remove(tutorEncontrado);
            _appContext.SaveChanges();
        }

        Tutor IRepositorioTutor.GetTutor(int IdTutor){
            var tutorEncontrado = _appContext.Tutores.FirstOrDefault(p => p.Id == IdTutor);
            return tutorEncontrado;

        }

        IEnumerable<Tutor> IRepositorioTutor.GetAllTutor(){
            return _appContext.Tutores;
        }
    }
}