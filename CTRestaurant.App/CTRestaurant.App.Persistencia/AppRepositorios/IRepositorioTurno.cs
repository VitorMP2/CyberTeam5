using System.Collections.Generic;
using CTRestaurant.App.Dominio;

namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioTurno
    {
        IEnumerable<Turno> GetAllTurno();
        Turno AddTurno (Turno Turno);
        Turno UpdateTurno (Turno Turno);
        bool DeleteTurno (int IdTurno);
        Turno GetTurno (int IdTurno);
        Turno GetTurnoCliente(int IdTurno);
        //IEnumerable<Turno> GetTurnosNuevos();
    }
}