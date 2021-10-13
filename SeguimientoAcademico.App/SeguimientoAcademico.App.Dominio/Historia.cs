using System;

namespace SeguimientoAcademico.App.Dominio
{
    public class Historia
    {
        public int Id {get;set;}
        public string Tarea {get;set;}
        public int Calificacion {get;set;}
        public int Id_Maestro {get;set;}
        public string Estado {get;set;}
        public List<Sugerencia> Sugerencia {get;set;}
        
    
    }
}