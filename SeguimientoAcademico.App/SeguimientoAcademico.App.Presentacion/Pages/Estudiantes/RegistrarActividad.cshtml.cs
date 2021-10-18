using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoAcademico.App.Persistencia.AppRepositorios;
using SeguimientoAcademico.App.Dominio;

namespace SeguimientoAcademico.App.Presentacion.Pages
{
    public class RegistrarActividadModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiante {get;set;}
        public Historia historia {get;set;}

        public RegistrarActividadModel(IRepositorioEstudiante _repoEstudiante){
            this._repoEstudiante = _repoEstudiante;
        }
        public IActionResult OnGet(int id)
        {
            estudiante=_repoEstudiante.GetEstudiante(id);
            if(estudiante!=null){
                return Page();
            }
            else{
                return NotFound();
            }
        }

        public IActionResult OnPost(int id, Historia historia){
            _repoEstudiante.AddHistoria(id,historia);
            return RedirectToPage("/Estudiantes/Index");
        }
    }
}
