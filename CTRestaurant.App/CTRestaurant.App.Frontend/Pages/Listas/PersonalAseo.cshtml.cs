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
    public class PersonalAseoModel : PageModel
    {
         private static IRepositorioPersonalAseo _repoPersonalAseo=new RepositorioPersonalAseo(new Persistencia.AppContext());
        public IEnumerable<PersonalAseo> PersonalAseos {get;set;}
        public void OnGet()

        {
            PersonalAseos =_repoPersonalAseo.GetAllPersonalAseos();
        }
    }
}
