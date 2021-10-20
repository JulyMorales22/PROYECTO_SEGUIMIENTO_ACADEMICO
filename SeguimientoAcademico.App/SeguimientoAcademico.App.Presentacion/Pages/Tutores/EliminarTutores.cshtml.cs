using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoAcademico.App.Dominio;
using SeguimientoAcademico.App.Persistencia.AppRepositorios;

namespace SeguimientoAcademico.App.Presentacion.Pages
{
    public class EliminarTutoresModel : PageModel
    {
         private readonly IRepositorioTutor _repoTutor;
        public Tutor tutor {get;set;}
        
        public EliminarTutoresModel(IRepositorioTutor _repoTutor){
            this._repoTutor = _repoTutor;
        }
        public IActionResult OnGet(int id)
        {
            tutor = _repoTutor.GetTutor(id);
            if(tutor != null){
                return Page();
            } 
            else{
                return NotFound();
            }
        }

        public IActionResult OnPost(int id){
            _repoTutor.DeleteTutor(id);
            return RedirectToPage("/Tutores/IndexTutores");
        }
    }
}
