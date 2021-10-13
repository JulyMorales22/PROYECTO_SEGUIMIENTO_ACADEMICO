using System;

namespace SeguimientoAcademico.App.Dominio
{
    public class Maestro:Persona
    {
        public string LicenciaProfesional {get;set;}
        public string Especialidad {get;set;}
        public string MateriaAsignada {get;set;}
    }
}