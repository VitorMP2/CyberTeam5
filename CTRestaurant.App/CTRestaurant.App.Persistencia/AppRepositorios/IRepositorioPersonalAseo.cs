using System.Collections.Generic;
using CTRestaurant.App.Dominio;


namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioPersonalAseo
    {   //CRUD
        //AddPersonalAseo
        PersonalAseo AddPersonalAseo(PersonalAseo personalAseo);
        //GetPersonalAseo
        PersonalAseo GetPersonalAseo(int personalAseoIdentificacion);
        //UpdatePersonalAseo
        PersonalAseo UpdatePersonalAseo(PersonalAseo personalAseo);
        //DeletePersonalAseo
        bool DeletePersonalAseo(int personalAseoIdentificacion);
        //GetAllPersonalAseo
        IEnumerable<PersonalAseo>  GetAllPersonalAseos();

    }
}