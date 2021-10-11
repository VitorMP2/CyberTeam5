using System.Collections.Generic;
using CTRestaurant.App.Dominio;


namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioEstudiante
    {   //CRUD
        //AddEstudiante
        Estudiante AddEstudiante(Estudiante estudiante);
        //GetEstudiante
        Estudiante GetEstudiante(int estudianteid);
        //UpdateEstudiante
        Estudiante UpdateEstudiante(Estudiante estudiante);
        //DeleteEstudiante
        bool DeleteEstudiante(int Estudianteid);
        //GetAllEstudiante
        IEnumerable<Estudiante>  GetAllEstudiantes();

    }
}