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
    public class ActualizarFamiliarDesignadoModel : PageModel
    {
        private readonly IRepositorioFamiliarDesignado _repoFamiliarDesignado;
        public FamiliarDesignado familiarDesignado {get;set;}

        public ActualizarFamiliarDesignadoModel(IRepositorioFamiliarDesignado _repoFamiliarDesignado){
            this._repoFamiliarDesignado = _repoFamiliarDesignado;
        }
        public IActionResult OnGet(int id)
        {
            familiarDesignado = _repoFamiliarDesignado.GetFamiliarDesignado(id);
            if(familiarDesignado!=null)
        {
            return Page();
        }
        else{
            return NotFound();
        }
        }

        public IActionResult OnPost(FamiliarDesignado familiarDesignado){
        _repoFamiliarDesignado.UpdateFamiliarDesignado(familiarDesignado);
        return RedirectToPage("/FamiliarDesignado/IndexFamiliarDesignado");
        }
        
    }
}
