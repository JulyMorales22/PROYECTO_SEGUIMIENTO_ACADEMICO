using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSugerencia
    {
    IEnumerable<Sugerencia> GetAllSugerencia();

    Sugerencia AddSugerencia(Sugerencia Sugerencia);

    Sugerencia UpdateSugerencia (Sugerencia Sugerencia);

    void DeleteSugerencia(int IdSugerencia);

    Sugerencia GetSugerencia(int IdSugerencia); 
    }
}