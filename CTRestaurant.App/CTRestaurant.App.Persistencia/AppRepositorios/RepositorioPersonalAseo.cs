using System.Collections.Generic;
using CTRestaurant.App.Dominio;
using System.Linq;

namespace CTRestaurant.App.Persistencia
{
    public class RepositorioPersonalAseo : IRepositorioPersonalAseo
    {
        private static AppContext _appContext;
        public RepositorioPersonalAseo(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD
        //AgregarPersonalAseo
        PersonalAseo IRepositorioPersonalAseo.AddPersonalAseo(PersonalAseo personalAseo)
        {
            var personalAseoAdicionado = _appContext.PersonalAseo.Add(personalAseo);
            _appContext.SaveChanges();
            return personalAseoAdicionado.Entity;
        }
        //BuscarPersonalAseo
        PersonalAseo IRepositorioPersonalAseo.GetPersonalAseo(int personalAseoIdentificacion)
        {
            var personalAseoEncontrado = _appContext.PersonalAseo.FirstOrDefault(p => p.identificacion == personalAseoIdentificacion);
            return personalAseoEncontrado;
        }
        //ActualizarPersonalAseo
        PersonalAseo IRepositorioPersonalAseo.UpdatePersonalAseo(PersonalAseo personalAseo)
        {
            var personalAseoEncontrado = _appContext.PersonalAseo.FirstOrDefault(p => p.identificacion == personalAseo.identificacion);
            if (personalAseoEncontrado != null)
            {
                personalAseoEncontrado.nombre =  personalAseo.nombre;
                 personalAseoEncontrado.apellido =  personalAseo.apellido;
                 personalAseoEncontrado.identificacion =  personalAseo.identificacion;
                 personalAseoEncontrado.Turno_servcio_aseo =  personalAseo.Turno_servcio_aseo;
                 personalAseoEncontrado.edad =  personalAseo.edad;
                 personalAseoEncontrado.estadoCovid =  personalAseo.estadoCovid;
                _appContext.SaveChanges();
            }
            return personalAseoEncontrado;
        }
        //BorrarPersonalAseo
        bool IRepositorioPersonalAseo.DeletePersonalAseo(int personalAseoid)
        {
            var personalAseoEncontrado = _appContext.PersonalAseo.FirstOrDefault(p => p.id == personalAseoid);
            if (personalAseoEncontrado == null)
                return false;
             _appContext.PersonalAseo.Remove(personalAseoEncontrado);
            _appContext.SaveChanges();
            return true;
        }
        //BuscarPersonalAseo
        IEnumerable<PersonalAseo> IRepositorioPersonalAseo.GetAllPersonalAseos()
        {
             return _appContext.PersonalAseo;
        }
    }


}