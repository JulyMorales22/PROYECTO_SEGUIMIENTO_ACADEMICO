using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;


namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstudiante
    {
    IEnumerable<Estudiante> GetAllEstudiante();

    Estudiante AddEstudiante(Estudiante Estudiante);

    Estudiante UpdateEstudiante  (Estudiante Estudiante);

    void DeleteEstudiante(int IdEstudiante);

    Estudiante GetEstudiante(int IdEstudiante);

    void AddHistoria (int IdEstudiante, Historia historia);

    void AddMateria (int IdEstudiante, Materia materia);
    //void AddSugerencia_o_tareas(Sugerencia sugerencia, int IdEstudiante);


    }
}