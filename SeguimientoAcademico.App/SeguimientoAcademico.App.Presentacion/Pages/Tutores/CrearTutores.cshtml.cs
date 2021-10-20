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
    public class CrearTutoresModel : PageModel
    {
        
        private readonly IRepositorioTutor _repoTutor;
        public Tutor tutor {get;set;}

        public  CrearTutoresModel(IRepositorioTutor _repoTutor){
            this._repoTutor = _repoTutor;
        }
        public void OnGet()
        {
            tutor = new Tutor();
        }

        public IActionResult OnPost (Tutor tutor){
            _repoTutor.AddTutor(tutor);
           return RedirectToPage ("/Tutores/IndexTutores");
        }
    }
}
