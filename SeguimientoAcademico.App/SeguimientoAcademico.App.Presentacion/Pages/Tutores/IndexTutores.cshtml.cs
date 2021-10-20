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
    public class IndexTutoresModel : PageModel
    {
        private readonly IRepositorioTutor _repoTutor;
        public IEnumerable<Tutor> tutores{get;set;}

        public Tutor tutor {get;set;}

        public IndexTutoresModel (IRepositorioTutor _repoTutor){
            this._repoTutor = _repoTutor;
        }
        public void OnGet()
        {
            tutores = _repoTutor.GetAllTutor();
        }
    }
}
