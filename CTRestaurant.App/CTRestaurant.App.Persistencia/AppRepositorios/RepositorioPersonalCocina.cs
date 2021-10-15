using System.Collections.Generic;
using CTRestaurant.App.Dominio;
using System.Linq;

namespace CTRestaurant.App.Persistencia
{
    public class RepositorioPersonalCocina : IRepositorioPersonalCocina
    {
        private static AppContext _appContext;
        public RepositorioPersonalCocina(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD
        //AgregarPersonalCocina
        PersonalCocina IRepositorioPersonalCocina.AddPersonalCocina(PersonalCocina personalCocina)
        {
            var personalCocinaAdicionado = _appContext.PersonalCocina.Add(personalCocina);
            _appContext.SaveChanges();
            return personalCocinaAdicionado.Entity;
        }
        //BuscarPersonalCocina
        PersonalCocina IRepositorioPersonalCocina.GetPersonalCocina(int personalCocinaIdentificacion)
        {
            var personalCocinaEncontrado = _appContext.PersonalCocina.FirstOrDefault(p => p.identificacion == personalCocinaIdentificacion);
            return personalCocinaEncontrado;
        }
        //ActualizarPersonalCocina
        PersonalCocina IRepositorioPersonalCocina.UpdatePersonalCocina(PersonalCocina personalCocina)
        {
            var personalCocinaEncontrado = _appContext.PersonalCocina.FirstOrDefault(p => p.identificacion == personalCocina.identificacion);
            if (personalCocinaEncontrado != null)
            {
                personalCocinaEncontrado.nombre =  personalCocina.nombre;
                 personalCocinaEncontrado.apellido =  personalCocina.apellido;
                 personalCocinaEncontrado.identificacion =  personalCocina.identificacion;
                 personalCocinaEncontrado.Turno_servcio_cocina =  personalCocina.Turno_servcio_cocina;
                 personalCocinaEncontrado.edad =  personalCocina.edad;
                 personalCocinaEncontrado.estadoCovid =  personalCocina.estadoCovid;
                _appContext.SaveChanges();
            }
            return personalCocinaEncontrado;
        }
        //BorrarPersonalCocina
        bool IRepositorioPersonalCocina.DeletePersonalCocina(int personalCocinaid)
        {
            var personalCocinaEncontrado = _appContext.PersonalCocina.FirstOrDefault(p => p.id == personalCocinaid);
            if (personalCocinaEncontrado == null)
                return false;
             _appContext.PersonalCocina.Remove(personalCocinaEncontrado);
            _appContext.SaveChanges();
            return true;
        }
        //BuscarPersonalCocina
        IEnumerable<PersonalCocina> IRepositorioPersonalCocina.GetAllPersonalCocinas()
        {
             return _appContext.PersonalCocina;
        }
    }


}