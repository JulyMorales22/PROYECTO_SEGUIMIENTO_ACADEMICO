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
    public class EliminarMaestrosModel : PageModel
    {

        private readonly IRepositorioMaestro _repoMaestro;
        public Maestro maestro {get;set;}

        public EliminarMaestrosModel(IRepositorioMaestro _repoMaestro){
            this._repoMaestro=_repoMaestro;
        }
        public IActionResult OnGet(int id)
        {
            maestro=_repoMaestro.GetMaestro(id);
            if(maestro!=null)
            {
                return Page();
            }
            else
            {
                return NotFound();
            }
        }

         public IActionResult OnPost(int id)
        {
            _repoMaestro.DeleteMaestro(id);
             return RedirectToPage("/Maestros/IndexMaestros");
        }
    }
}
