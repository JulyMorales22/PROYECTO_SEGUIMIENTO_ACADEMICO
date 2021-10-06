using System.Collections.Generic;
using SeguimientoAcademico.App.Dominio;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFamiliarDesignado
    {

    IEnumerable<FamiliarDesignado> GetAllFamiliarDesignado();

    FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado FamiliarDesignado);

    FamiliarDesignado UpdateFamiliarDesignado (FamiliarDesignado FamiliarDesignado);

    void DeleteFamiliarDesignado(int IdFamiliarDesignado);

    FamiliarDesignado GetFamiliarDesignado(int IdFamiliarDesignado);

    }
}