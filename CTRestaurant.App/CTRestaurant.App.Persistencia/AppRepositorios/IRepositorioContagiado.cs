using System.Collections.Generic;
using CTRestaurant.App.Dominio;

namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioContagiado
    {
        IEnumerable<Contagiado> GetAllContagiados();

        Contagiado AddContagiado (Contagiado contagiado);

        Contagiado UpdateContagiado (Contagiado contagiado);

        bool DeleteContagiado (int IdContagiado);

        Contagiado GetContagiado (int IdContagiado);
    }
}