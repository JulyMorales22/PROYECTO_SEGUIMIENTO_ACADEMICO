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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        [BindProperty]
        public Estudiante estudiante { get; set; }

        public ActualizarModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante = _repoEstudiante;
        }

        public IActionResult OnGet(int id)
        {
            estudiante = _repoEstudiante.GetEstudiante(id);
            if (estudiante != null)
            {
                return Page();
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult OnPost()
        {
            estudiante = _repoEstudiante.UpdateEstudiante(estudiante);
            return RedirectToPage("/Estudiantes/Index");
        }


    }
}
