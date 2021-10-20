using Microsoft.EntityFrameworkCore;
using SeguimientoAcademico.App.Dominio;


namespace SeguimientoAcademico.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet <Persona> Personas {get;set;}
        public DbSet <Estudiante> Estudiantes {get;set;}
        
        public DbSet <Maestro> Maestros {get;set;}
        public DbSet <Tutor> Tutores {get;set;}  
        public DbSet <Historia> Historias {get;set;}
        public DbSet <Sugerencia> Sugerencias {get;set;}   
        public DbSet <Materia> Materias {get;set;}
        
         protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {

            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Server=tcp:servidorgrupo8.database.windows.net,1433;Initial Catalog=SeguimientoAcademico;Persist Security Info=False;User ID=admin_01;Password=Academico8;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");    

            }   
         }  
       
    }
}