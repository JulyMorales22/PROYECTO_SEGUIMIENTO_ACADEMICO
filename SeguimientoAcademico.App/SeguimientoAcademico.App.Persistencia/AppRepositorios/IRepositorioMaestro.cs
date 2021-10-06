using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;


namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMaestro
    {
    IEnumerable<Maestro> GetAllMaestro();

    Maestro AddMaestro(Maestro Maestro);

    Maestro UpdateMaestro  (Maestro Maestro);

    void DeleteMaestro(int IdMaestro);

    Maestro GetMaestro(int IdMaestro);
    }
}