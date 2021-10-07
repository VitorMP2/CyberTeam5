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
    public class DetallesModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor =new RepositorioProfesor(new Persistencia.AppContext());
        public Profesor profesor{get;set;}
        public IActionResult OnGet(int profesoridentificacion)
        {
            
            profesor= _repoProfesor.GetProfesor(profesoridentificacion);
           
            if (profesor==null)
            {
                return  RedirectToPage("./Profesores");
            }
            return Page();
        }
    }
}
