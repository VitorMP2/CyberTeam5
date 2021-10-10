using System.Collections.Generic;
using CTRestaurant.App.Dominio;
using System.Linq;

namespace CTRestaurant.App.Persistencia
{
    public class RepositorioAdministrativo : IRepositorioAdministrativo
    {
        private static AppContext _appContext;
        public RepositorioAdministrativo(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD
        //AgregarProfesor
        Administrativo IRepositorioAdministrativo.AddAdministrativo(Administrativo administrativo)
        {
            var administrativoAdicionado = _appContext.Administrativos.Add(administrativo);
            _appContext.SaveChanges();
            return administrativoAdicionado.Entity;
        }
        //BuscarProfesor
        Administrativo IRepositorioAdministrativo.GetAdministrativo(int administrativoid)
        {
            var administrativoEncontrado = _appContext.Administrativos.FirstOrDefault(p => p.id == administrativoid);
            return administrativoEncontrado;
        }
        //ActualizarProfesor
        Administrativo IRepositorioAdministrativo.UpdateAdministrativo(Administrativo administrativo)
        {
            var administrativoEncontrado = _appContext.Administrativos.FirstOrDefault(p => p.identificacion == administrativo.identificacion);
            if (administrativoEncontrado != null)
            {
                administrativoEncontrado.nombre = administrativo.nombre;
                administrativoEncontrado.apellido = administrativo.apellido;
                administrativoEncontrado.identificacion = administrativo.identificacion;
                administrativoEncontrado.Oficina = administrativo.Oficina;
                administrativoEncontrado.Dependencia = administrativo.Dependencia;
                administrativoEncontrado.edad = administrativo.edad;
                administrativoEncontrado.estadoCovid = administrativo.estadoCovid;
                _appContext.SaveChanges();
            }
            return administrativoEncontrado;
        }
        //BorrarProfesor
        bool IRepositorioAdministrativo.DeleteAdministrativo(int administrativoid)
        {
            var administrativoEncontrado = _appContext.Administrativos.FirstOrDefault(p => p.id == administrativoid);
            if (administrativoEncontrado == null)
                return false;
            _appContext.Administrativos.Remove(administrativoEncontrado);
            _appContext.SaveChanges();
            return true;
        }
        //BuscarProfesores
        IEnumerable<Administrativo> IRepositorioAdministrativo.GetAllAdministrativos()
        {
            return _appContext.Administrativos;
        }
    }


}