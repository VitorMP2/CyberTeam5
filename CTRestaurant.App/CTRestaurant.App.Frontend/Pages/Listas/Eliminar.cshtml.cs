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
    public class EliminarModel : PageModel
    {
        private static IRepositorioProfesor  _repoProfesor= new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        public Profesor profesor{get;set;}
        
        public IActionResult OnGet(int profesorid)

        {
            profesor= _repoProfesor.GetProfesor(profesorid);
            return Page ();
        }
        public IActionResult OnPost ()
        {
            _repoProfesor.DeleteProfesor(profesor.id);
            return RedirectToPage("./Profesores");
        }
    }
}
