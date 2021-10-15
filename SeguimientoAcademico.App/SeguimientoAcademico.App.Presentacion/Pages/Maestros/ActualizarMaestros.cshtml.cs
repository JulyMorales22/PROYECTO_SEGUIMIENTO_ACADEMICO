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
    public class ActualizarMaestrosModel : PageModel
    {

        private readonly IRepositorioMaestro _repoMaestro;

        public Maestro maestro{get;set;}

        public ActualizarMaestrosModel(IRepositorioMaestro _repoMaestro){
            this._repoMaestro = _repoMaestro;

        }
        public IActionResult OnGet(int id)
        {
            maestro = _repoMaestro.GetMaestro(id);
            if(maestro!=null)
            {
                return Page();
            }
            else{
                return NotFound();
            }
        }

        public IActionResult OnPost(Maestro maestro){
            _repoMaestro.UpdateMaestro(maestro);
            return RedirectToPage("/Maestros/IndexMaestros");
        }
    }
}
