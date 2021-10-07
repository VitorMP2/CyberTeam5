using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
<<<<<<< HEAD
using CTRestaurant.App.Persistencia;
using CTRestaurant.App.Dominio;

=======
using CTRestaurant.App.Dominio;
using CTRestaurant.App.Persistencia;
>>>>>>> 93413183007c681deb60033ac475aed98e2d5830
namespace CTRestaurant.App.Frontend.Pages
{
    public class EliminarModel : PageModel
    {
<<<<<<< HEAD
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
=======
        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());
        [BindProperty]
        public Restaurante registro{get;set;}
        public IActionResult OnGet(int IdRegistro)
        {
            registro=_repoRestaurante.GetRegistro(IdRegistro);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoRestaurante.DeleteRegistro(registro.Id);
            return RedirectToPage("./RegistrosRestaurante");
>>>>>>> 93413183007c681deb60033ac475aed98e2d5830
        }
    }
}
