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
    public class RegistrarMateriaModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiante {get;set;}
        public Materia materia {get;set;}
        public RegistrarMateriaModel(IRepositorioEstudiante _repoEstudiante){
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

        public IActionResult OnPost(int id, Materia materia){
            _repoEstudiante.AddMateria(id,materia);
            return RedirectToPage("/Estudiantes/Index");
        }
    }
}
