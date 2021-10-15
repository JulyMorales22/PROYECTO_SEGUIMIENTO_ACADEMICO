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
    public class IndexMaestrosModel : PageModel
    {
        
        private readonly IRepositorioMaestro _repoMaestro;
        public IEnumerable<Maestro> maestros {get;set;}
        public Maestro maestro {get;set;}

        public IndexMaestrosModel (IRepositorioMaestro _repoMaestro){

            this._repoMaestro =_repoMaestro;
        }
        public void OnGet()
        {
            maestros= _repoMaestro.GetAllMaestro();
            
        }
    }
}
