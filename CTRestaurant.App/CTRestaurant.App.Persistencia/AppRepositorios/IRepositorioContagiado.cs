using System.Collections.Generic;
using CTRestaurant.App.Dominio;

namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioContagiado
    {
        IEnumerable<Contagiado> GetAllContagiado();

        Contagiado AddContagiado (Contagiado contagiado);

        Contagiado UpdateContagiado (Contagiado contagiado);

        void DeleteContagiado (int IdContagiado);

        Contagiado GetContagiado (int IdContagiado);
    }
}