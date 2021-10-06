using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
    IEnumerable<Persona> GetAllPersona();

    Persona AddPersona(Persona Persona);

    Persona UpdatePersona  (Persona Persona);

    void DeletePersona(int IdPersona);

    Persona GetPersona(int IdPersona);  
    }
}