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
    public class PersonalCocinaModel : PageModel
    {
           private static IRepositorioPersonalCocina _repoPersonalCocina=new RepositorioPersonalCocina(new Persistencia.AppContext());
        public IEnumerable<PersonalCocina> PersonalCocinas {get;set;}
        public void OnGet()
        {
            PersonalCocinas =_repoPersonalCocina.GetAllPersonalCocinas();
        }
    }
}
