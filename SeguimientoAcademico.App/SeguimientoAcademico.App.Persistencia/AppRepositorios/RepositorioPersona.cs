using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using SeguimientoAcademico.App.Persistencia;


namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona :IRepositorioPersona
    {
        private readonly /*SeguimientoAcademico.App.Persistencia.*/AppContext _appContext = new AppContext();
       /* public RepositorioPersona(SeguimientoAcademico.App.Persistencia.AppContext appContext){
        _appContext=appContext;
        }*/

        Persona IRepositorioPersona.AddPersona(Persona persona){
           var personaAdicionada = _appContext.Personas.Add(persona);
           _appContext.SaveChanges();
           return personaAdicionada.Entity; 

        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona){
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id ==  persona.Id);
            if (personaEncontrada!=null)
            
            {
               personaEncontrada.Nombre=persona.Nombre;
               personaEncontrada.Apellido=persona.Apellido;
               personaEncontrada.Telefono=persona.Telefono;
               personaEncontrada.Genero=persona.Genero;
               
               _appContext.SaveChanges();
            }return personaEncontrada;

              
        }

        void IRepositorioPersona.DeletePersona(int Idpersona){
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == Idpersona);
            if(personaEncontrada==null)
            
               return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }

        Persona IRepositorioPersona.GetPersona(int Idpersona){
            var personaEncontrada = _appContext.Estudiantes.FirstOrDefault(p => p.Id == Idpersona);
            return personaEncontrada;

        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersona(){
            return _appContext.Personas;
        }

    }
}