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
    public class CrearFamiliarDesignadoModel : PageModel
    {
        private readonly IRepositorioFamiliarDesignado _repoFamiliarDesignado;
        public FamiliarDesignado familiarDesignado {get;set;}

        public CrearFamiliarDesignadoModel(IRepositorioFamiliarDesignado _repoFamiliarDesignado){
            this._repoFamiliarDesignado = _repoFamiliarDesignado;
        }
        public void OnGet()
        {
            familiarDesignado = new FamiliarDesignado();
        }

        public IActionResult OnPost(FamiliarDesignado familiarDesignado){
            _repoFamiliarDesignado.AddFamiliarDesignado(familiarDesignado);
            return RedirectToPage("/FamiliarDesignado/IndexFamiliarDesignado");
        }
    }
}
