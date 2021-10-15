using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMateria
    {

     IEnumerable<Materia> GetAllMateria();

    Materia AddMateria(Materia Materia);

    Materia UpdateMateria  (Materia Materia);

    void DeleteMateria(int IdMateria);

    Materia GetMateria(int IdMateria);
        
    }
}