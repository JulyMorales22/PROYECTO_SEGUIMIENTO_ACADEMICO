using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoAcademico.App.Dominio;
using SeguimientoAcademico.App.Persistencia.AppRepositorios;
using SeguimientoAcademico.App.Persistencia;

namespace SeguimientoAcademico.App.Presentacion.Pages
{
    public class CrearMaestrosModel : PageModel
    {

        private readonly IRepositorioMaestro _repoMaestro;

        public Maestro maestro{get;set;}

        public CrearMaestrosModel (IRepositorioMaestro _repoMaestro){
            this._repoMaestro=_repoMaestro;
        }
        public void OnGet()
        {
            maestro = new Maestro();
        }

        public IActionResult OnPost(Maestro maestro){

            _repoMaestro.AddMaestro(maestro);
            return RedirectToPage("/Maestros/IndexMaestros");
        }
    }
}
