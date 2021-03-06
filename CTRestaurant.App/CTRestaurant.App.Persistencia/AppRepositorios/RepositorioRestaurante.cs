using System.Collections.Generic;
using System.Linq;
using CTRestaurant.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System;

namespace CTRestaurant.App.Persistencia
{
    public class RepositorioRestaurante:IRepositorioRestaurante
    {
        private static AppContext _appContext;

        public RepositorioRestaurante(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<Restaurante> IRepositorioRestaurante.GetAllRestaurante()
        {
            return _appContext.Restaurante;
        }

        Restaurante IRepositorioRestaurante.AddRegistro (Restaurante Registro)
        {
            var RegistroAdicionado=_appContext.Restaurante.Add(Registro);
            _appContext.SaveChanges();
            return RegistroAdicionado.Entity;
        }

        Restaurante IRepositorioRestaurante.UpdateRegistro (Restaurante Registro)
        {
            var RegistroEncontrado=_appContext.Restaurante.FirstOrDefault(r => r.Id==Registro.Id);
            if(RegistroEncontrado!=null)
            {
                RegistroEncontrado.FechaRegistro=Registro.FechaRegistro;
                RegistroEncontrado.Aforo=Registro.Aforo;
                RegistroEncontrado.CantidadMesas=Registro.CantidadMesas;
                RegistroEncontrado.PuestosPorMesa=Registro.PuestosPorMesa;

                _appContext.SaveChanges();                
            }
            return RegistroEncontrado;
        }

        bool IRepositorioRestaurante.DeleteRegistro (int IdRegistro)
        {
            var RegistroEncontrado=_appContext.Restaurante.FirstOrDefault(r => r.Id==IdRegistro);
            if(RegistroEncontrado==null)
                return false;
            _appContext.Restaurante.Remove(RegistroEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        Restaurante IRepositorioRestaurante.GetRegistro (int IdRegistro)
        {            
            return _appContext.Restaurante.FirstOrDefault(r => r.Id==IdRegistro);
        }

        Restaurante IRepositorioRestaurante.GetRegistroTurno(int IdRegistro)
        {
            return _appContext.Restaurante.Include(p=>p.Turnos).FirstOrDefault(r=>r.Id==IdRegistro);
        }
    }
}