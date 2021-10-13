using System.Collections.Generic;
using CTRestaurant.App.Dominio;

namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioRestaurante
    {
        IEnumerable<Restaurante> GetAllRestaurante();

        Restaurante AddRegistro (Restaurante Registro);

        Restaurante UpdateRegistro (Restaurante Registro);

        bool DeleteRegistro (int IdRegistro);

        Restaurante GetRegistro (int IdRegistro);
    }
}