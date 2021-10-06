using System;

namespace SeguimientoAcademico.App.Dominio
{
    public class Estudiante:Persona
    {
        public string MateriasInscritas{get;set;}
        public string Grado{get;set;}
        public string Direccion{get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad{get;set;}
        public FamiliarDesignado Familiar {get;set;}
        public Maestro Maestro {get; set;}
        public Tutor Tutor {get;set;}
        public Historia Historia {get;set;}
    }
}