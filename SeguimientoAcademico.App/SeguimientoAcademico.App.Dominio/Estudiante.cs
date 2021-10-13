using System;
using System.Collections.Generic;

namespace SeguimientoAcademico.App.Dominio
{
    public class Estudiante:Persona
    {
        public List<Materia> MateriasInscritas{get;set;}
        public string Grado{get;set;}
        public string Direccion{get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad{get;set;}
        public FamiliarDesignado Familiar {get;set;}
        public List<Maestro> Maestro {get; set;}
        public Tutor Tutor {get;set;}
        public List<Historia> Historia {get;set;}
    }
}