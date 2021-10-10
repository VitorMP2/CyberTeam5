using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTRestaurant.App.Persistencia;
using CTRestaurant.App.Dominio;

namespace CTRestaurant.App.Frontend.Pages
{
    public class AdministrativosModel : PageModel
    {
        private static IRepositorioAdministrativo _repoAdministrativo=new RepositorioAdministrativo(new Persistencia.AppContext());
        public IEnumerable<Administrativo> Administrativos {get;set;}
        public void OnGet()
        {
             Administrativos =_repoAdministrativo.GetAllAdministrativos();
        }
    }
}
