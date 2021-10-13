using System.Collections.Generic;
using CTRestaurant.App.Dominio;



namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioProfesor
    {   //CRUD
        //AddProfesor
        Profesor AddProfesor(Profesor profesor);
        //GetProfesor
        Profesor GetProfesor(int profesorIdentificacion);
        //UpdateProfesor
        Profesor UpdateProfesor(Profesor profesor);
        //DeleteProfesor
        bool DeleteProfesor(int profesorid);
        //GetAllProfesores
        IEnumerable<Profesor>  GetAllProfesores();

    }
}
