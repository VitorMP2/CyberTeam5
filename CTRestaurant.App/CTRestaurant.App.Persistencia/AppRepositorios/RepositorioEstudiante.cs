using System.Collections.Generic;
using CTRestaurant.App.Dominio;
using System.Linq;

namespace CTRestaurant.App.Persistencia
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private static AppContext _appContext;
        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD
        //AgregarEstudiante
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }
        //BuscarEstudiante
        Estudiante IRepositorioEstudiante.GetEstudiante(int estudianteid)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == estudianteid);
            return estudianteEncontrado;
        }
        //ActualizarEstudiante
        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.identificacion == estudiante.identificacion);
            if (estudianteEncontrado != null)
            {
                estudianteEncontrado.nombre =  estudiante.nombre;
                 estudianteEncontrado.apellido =  estudiante.apellido;
                 estudianteEncontrado.identificacion =  estudiante.identificacion;
                 estudianteEncontrado.Programa =  estudiante.Programa;
                 estudianteEncontrado.edad =  estudiante.edad;
                 estudianteEncontrado.estadoCovid =  estudiante.estadoCovid;
                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }
        //BorrarEstudiante
        bool IRepositorioEstudiante.DeleteEstudiante(int estudianteid)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == estudianteid);
            if (estudianteEncontrado == null)
                return false;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
            return true;
        }
        //BuscarEstudiantes
        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }
    }


}