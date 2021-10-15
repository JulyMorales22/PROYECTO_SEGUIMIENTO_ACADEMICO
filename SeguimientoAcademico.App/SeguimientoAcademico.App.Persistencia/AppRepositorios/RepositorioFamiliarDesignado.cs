using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using SeguimientoAcademico.App.Persistencia;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public class RepositorioFamiliarDesignado : IRepositorioFamiliarDesignado
    {
        private readonly AppContext _appContext = new AppContext();
        
        

        FamiliarDesignado IRepositorioFamiliarDesignado.AddFamiliarDesignado(FamiliarDesignado familiarDesignado){
           var familiarDesignadoAdicionado = _appContext.FamiliarDesignado.Add(familiarDesignado);
           _appContext.SaveChanges();
           return familiarDesignadoAdicionado.Entity; 

        }

        FamiliarDesignado IRepositorioFamiliarDesignado.UpdateFamiliarDesignado(FamiliarDesignado familiarDesignado){
            var familiarDesignadoEncontrado = _appContext.FamiliarDesignado.FirstOrDefault(p => p.Id ==  familiarDesignado.Id);
            if (familiarDesignadoEncontrado!=null)
            
            {
               familiarDesignadoEncontrado.Nombre=familiarDesignado.Nombre;
               familiarDesignadoEncontrado.Apellido=familiarDesignado.Apellido;
               familiarDesignadoEncontrado.Telefono=familiarDesignado.Telefono;
               familiarDesignadoEncontrado.Genero=familiarDesignado.Genero;
               familiarDesignadoEncontrado.Parentesco=familiarDesignado.Parentesco;
               

               _appContext.SaveChanges();
            }return familiarDesignadoEncontrado;

              
        }

        void IRepositorioFamiliarDesignado.DeleteFamiliarDesignado(int IdFamiliarDesignado){
            var familiarDesignadoEncontrado = _appContext.FamiliarDesignado.FirstOrDefault(p => p.Id == IdFamiliarDesignado);
            if(familiarDesignadoEncontrado==null)
            
               return;
            _appContext.FamiliarDesignado.Remove(familiarDesignadoEncontrado);
            _appContext.SaveChanges();
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.GetFamiliarDesignado(int IdFamiliarDesignado){
            var familiarDesignadoEncontrado = _appContext.FamiliarDesignado.FirstOrDefault(p => p.Id == IdFamiliarDesignado);
            return familiarDesignadoEncontrado;

        }

        IEnumerable<FamiliarDesignado> IRepositorioFamiliarDesignado.GetAllFamiliarDesignado(){
            return _appContext.FamiliarDesignado;
        }
    }
}