using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHistoria
    {
    IEnumerable<Historia> GetAllHistoria();

    Historia AddHistoria(Historia Historia);

    Historia UpdateHistoria (Historia Historia);

    void DeleteHistoria(int IdHistoria);

    Historia GetHistoria(int IdHistoria); 
    }
}