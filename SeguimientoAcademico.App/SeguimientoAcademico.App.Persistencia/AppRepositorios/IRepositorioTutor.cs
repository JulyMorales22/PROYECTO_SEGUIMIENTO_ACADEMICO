using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTutor
    {
    IEnumerable<Tutor> GetAllTutor();

    Tutor AddTutor(Tutor Tutor);

    Tutor UpdateTutor (Tutor Tutor);

    void DeleteTutor(int IdTutor);

    Tutor GetTutor(int IdTutor);
    }
}