using System.Collections.Generic;
using CTRestaurant.App.Dominio;


namespace CTRestaurant.App.Persistencia
{
    public interface IRepositorioAdministrativo
    {   //CRUD
        //AddAdministrativo
        Administrativo AddAdministrativo(Administrativo administrativo);
        //GetAdministrativo
        Administrativo GetAdministrativo(int administrativoid);
        //UpdateAdministrativo
        Administrativo UpdateAdministrativo(Administrativo administrativo);
        //DeleteAdministrativo
        bool DeleteAdministrativo(int Administrativoid);
        //GetAllAdministrativo
        IEnumerable<Administrativo>  GetAllAdministrativos();

    }
}
