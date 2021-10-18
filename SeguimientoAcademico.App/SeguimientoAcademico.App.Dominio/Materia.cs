namespace SeguimientoAcademico.App.Dominio
{
    public class Materia
    {
        public int Id {get;set;}
        public string NombreMateria {get;set;}
        public string CargaHoraria{get;set;}
        public int IdMaestro{get;set;}
        public int IdTutor{get;set;}
    }
}