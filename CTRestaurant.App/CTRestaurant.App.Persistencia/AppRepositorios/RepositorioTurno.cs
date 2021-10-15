using System.Collections.Generic;
using System.Linq;
using CTRestaurant.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System;

namespace CTRestaurant.App.Persistencia
{
    public class RepositorioTurno : IRepositorioTurno
    {
        private static AppContext _appContext;

        public RepositorioTurno(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<Turno> IRepositorioTurno.GetAllTurno()
        {
            return _appContext.Turno;
        }

        Turno IRepositorioTurno.AddTurno(Turno Turno)
        {
            var TurnoAdicionado = _appContext.Turno.Add(Turno);
            _appContext.SaveChanges();
            return TurnoAdicionado.Entity;
        }

        Turno IRepositorioTurno.UpdateTurno(Turno Turno)
        {
            var TurnoEncontrado = _appContext.Turno.FirstOrDefault(r => r.Id == Turno.Id);
            if (TurnoEncontrado != null)
            {
                TurnoEncontrado.HorarioAsistencia = Turno.HorarioAsistencia;
                TurnoEncontrado.Menu = Turno.Menu;

                _appContext.SaveChanges();
            }
            return TurnoEncontrado;
        }

        bool IRepositorioTurno.DeleteTurno(int IdTurno)
        {
            var TurnoEncontrado = _appContext.Turno.FirstOrDefault(r => r.Id == IdTurno);
            if (TurnoEncontrado == null)
                return false;
            _appContext.Turno.Remove(TurnoEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        Turno IRepositorioTurno.GetTurno(int IdTurno)
        {
            return _appContext.Turno.FirstOrDefault(r => r.Id == IdTurno);
        }

        Turno IRepositorioTurno.GetTurnoCliente(int IdTurno)
        {
            return _appContext.Turno.Include(t => t.Cliente).FirstOrDefault(t => t.Id == IdTurno);
        }
    }
}