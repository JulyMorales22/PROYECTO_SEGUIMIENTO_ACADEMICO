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
    public class ActuaizarTutoresModel : PageModel
    {
          private readonly IRepositorioTutor _repoTutor;
        public Tutor tutor {get;set;}

        public ActuaizarTutoresModel(IRepositorioTutor _repoTutor){
            this._repoTutor = _repoTutor;
        }
        public IActionResult OnGet(int id)
        {
            tutor = _repoTutor.GetTutor(id);
            if (tutor!=null){
                return Page();
            }
            else {
                return NotFound();
            }
        }

        public IActionResult Onpost(Tutor tutor){
            _repoTutor.UpdateTutor(tutor);
            return RedirectToPage("/Tutores/IndexTutores");
        }
    }
}
