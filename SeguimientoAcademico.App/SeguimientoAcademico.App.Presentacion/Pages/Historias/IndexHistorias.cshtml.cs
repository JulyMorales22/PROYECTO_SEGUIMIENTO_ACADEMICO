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
    public class IndexHistoriasModel : PageModel
    {
        private readonly IRepositorioHistoria _repoHistoria;
        public Historia historia {get;set;}
        public void OnGet()
        {
        }
    }
}
