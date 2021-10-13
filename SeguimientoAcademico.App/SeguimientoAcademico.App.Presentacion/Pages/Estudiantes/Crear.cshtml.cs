using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoAcademico.App.Persistencia;
using SeguimientoAcademico.App.Dominio;
using SeguimientoAcademico.App.Persistencia.AppRepositorios;

namespace SeguimientoAcademico.App.Presentacion.Pages
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
         [BindProperty]
        public Estudiante estudiante{get;set;}

        public CrearModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante = _repoEstudiante;
        }
        public void OnGet()
        {
        }
         public IActionResult OnPost()
        {
            _repoEstudiante.AddEstudiante(estudiante);
            return RedirectToPage("/Estudiantes/Index");
        }
    }
}
