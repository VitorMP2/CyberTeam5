using System.Collections.Generic;
using CTRestaurant.App.Dominio;



namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioProfesor
    {   //CRUD
        //AddProfesor
        Profesor AddProfesor(Profesor profesor);
        //GetProfesor
        Profesor GetProfesor(int identificacion);
        //UpdateProfesor
        Profesor UpdateProfesor(Profesor profesor);
        //DeleteProfesor
        bool DeleteProfesor(int identificacion);
        //GetAllProfesores
        IEnumerable<Profesor>  GetAllProfesores();

    }
}
