using System.Collections.Generic;
using System.Linq;
using CTRestaurant.App.Dominio;

namespace CTRestaurant.App.Persistencia
{
    public class RepositorioContagiado : IRepositorioContagiado
    {
        private static AppContext _appContext;

        public RepositorioContagiado(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<Contagiado> IRepositorioContagiado.GetAllContagiado()
        {
            return _appContext.Contagiado;
        }

        Contagiado IRepositorioContagiado.AddContagiado(Contagiado Contagiado)
        {
            var ContagiadoAdicionado = _appContext.Contagiado.Add(Contagiado);
            _appContext.SaveChanges();
            return ContagiadoAdicionado.Entity;
        }

        Contagiado IRepositorioContagiado.UpdateContagiado(Contagiado Contagiado)
        {
            var ContagiadoEncontrado = _appContext.Contagiado.FirstOrDefault(r => r.Id == Contagiado.Id);
            if (ContagiadoEncontrado != null)
            {
                ContagiadoEncontrado.Sintomas = Contagiado.Sintomas;
                ContagiadoEncontrado.FechaDiagnostico = Contagiado.FechaDiagnostico;
                ContagiadoEncontrado.PeriodoAislamiento = Contagiado.PeriodoAislamiento;
                ContagiadoEncontrado.PersonaContagiada = Contagiado.PersonaContagiada;

                _appContext.SaveChanges();
            }
            return ContagiadoEncontrado;
        }

        void IRepositorioContagiado.DeleteContagiado(int IdContagiado)
        {
            var ContagiadoEncontrado = _appContext.Contagiado.FirstOrDefault(r => r.Id == IdContagiado);
            if (ContagiadoEncontrado == null)
                return;
            _appContext.Contagiado.Remove(ContagiadoEncontrado);
            _appContext.SaveChanges();
        }

        Contagiado IRepositorioContagiado.GetContagiado(int IdContagiado)
        {
            return _appContext.Contagiado.FirstOrDefault(r => r.Id == IdContagiado);
        }
    }
}