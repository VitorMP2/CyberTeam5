using System.Collections.Generic;
using CTRestaurant.App.Dominio;


namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioPersonalCocina
    {   //CRUD
        //AddPersonalCocina
        PersonalCocina AddPersonalCocina(PersonalCocina personalCocina);
        //GetPersonalCocina
        PersonalCocina GetPersonalCocina(int personalCocinaIdentificacion);
        //UpdatePersonalCocina
        PersonalCocina UpdatePersonalCocina(PersonalCocina personalCocina);
        //DeletePersonalCocina
        bool DeletePersonalCocina(int PersonalCocinaid);
        //GetAllPersonalCocina
        IEnumerable<PersonalCocina>  GetAllPersonalCocinas();

    }
}