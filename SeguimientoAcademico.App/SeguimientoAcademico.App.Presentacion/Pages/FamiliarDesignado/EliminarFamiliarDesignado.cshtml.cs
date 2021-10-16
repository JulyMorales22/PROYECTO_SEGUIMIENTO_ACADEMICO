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
    public class EliminarFamiliarDesignadoModel : PageModel
    {

        private readonly IRepositorioFamiliarDesignado _repoFamiliarDesignado;
        public FamiliarDesignado familiarDesignado{get;set;}

        public EliminarFamiliarDesignadoModel(IRepositorioFamiliarDesignado _repoFamiliarDesignado){
            this._repoFamiliarDesignado = _repoFamiliarDesignado;
        }


        public IActionResult OnGet(int id)
        {
            familiarDesignado = _repoFamiliarDesignado.GetFamiliarDesignado(id);
            if(familiarDesignado!=null){
                return Page();
            }
            else{
                return NotFound();
            }
        }

        public IActionResult OnPost(int id){
            _repoFamiliarDesignado.DeleteFamiliarDesignado(id);
            return RedirectToPage("/FamiliarDesignado/IndexFamiliarDesignado");
        }
    }
}
