using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoAcademico.App.Persistencia;
using SeguimientoAcademico.App.Dominio;
using SeguimientoAcademico.App.Persistencia.AppRepositorios;

namespace SeguimientoAcademico.App.Presentacion.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;

        public IEnumerable<Estudiante> estudiantes{get;set;}

        public Estudiante estudiante{get;set;}

        public IndexModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante =_repoEstudiante;
        }

        public void OnGet()
        {
            estudiantes= _repoEstudiante.GetAllEstudiante();       
        }

    
           
        
    }
}
