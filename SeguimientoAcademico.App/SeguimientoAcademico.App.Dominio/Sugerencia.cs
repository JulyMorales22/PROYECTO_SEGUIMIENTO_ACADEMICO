using System;

namespace SeguimientoAcademico.App.Dominio
{
    public class Sugerencia
    {
        public int Id {get;set;}
        public string Descripcion {get;set;}
        public string Tipo {get;set;}
        
        public int IdEstudiante {get;set;}
    }
}