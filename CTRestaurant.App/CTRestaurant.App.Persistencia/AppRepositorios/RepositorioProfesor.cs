using System.Collections.Generic;
using CTRestaurant.App.Dominio;
using System.Linq;

namespace CTRestaurant.App.Persistencia
{
    public class RepositorioProfesor : IRepositorioProfesor
    {
        private static AppContext _appContext;
        public RepositorioProfesor(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD
        //AgregarProfesor
        Profesor IRepositorioProfesor.AddProfesor(Profesor profesor)
        {
            var profesorAdicionado = _appContext.Profesores.Add(profesor);
            _appContext.SaveChanges();
            return profesorAdicionado.Entity;
        }
        //BuscarProfesor
        Profesor IRepositorioProfesor.GetProfesor(int profesorIdentificacion)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.identificacion == profesorIdentificacion);
            return profesorEncontrado;
        }
        //ActualizarProfesor
        Profesor IRepositorioProfesor.UpdateProfesor(Profesor profesor)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.identificacion == profesor.identificacion);
            if (profesorEncontrado != null)
            {
                profesorEncontrado.nombre = profesor.nombre;
                profesorEncontrado.apellido = profesor.apellido;
                profesorEncontrado.identificacion = profesor.identificacion;
                profesorEncontrado.Cubiculo = profesor.Cubiculo;
                profesorEncontrado.Facultad = profesor.Facultad;
                profesorEncontrado.edad = profesor.edad;
                profesorEncontrado.estadoCovid = profesor.estadoCovid;
                _appContext.SaveChanges();
            }
            return profesorEncontrado;
        }
        //BorrarProfesor
        bool IRepositorioProfesor.DeleteProfesor(int profesorid)
        {
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == profesorid);
            if (profesorEncontrado == null)
                return false;
            _appContext.Profesores.Remove(profesorEncontrado);
            _appContext.SaveChanges();
            return true;
        }
        //BuscarProfesores
        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesores()
        {
            return _appContext.Profesores;
        }
    }


}