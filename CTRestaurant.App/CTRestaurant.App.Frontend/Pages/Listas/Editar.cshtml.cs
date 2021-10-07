using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTRestaurant.App.Persistencia;
using CTRestaurant.App.Dominio;
<<<<<<< HEAD

=======
>>>>>>> 93413183007c681deb60033ac475aed98e2d5830
namespace CTRestaurant.App.Frontend.Pages
{
    public class EditarModel : PageModel
    {
<<<<<<< HEAD
        private static IRepositorioProfesor _repoProfesor= new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        public Profesor profesor{get;set;}
        public IActionResult OnGet(int? profesorid)

        {   
            if (profesorid.HasValue)
        {
            profesor= _repoProfesor.GetProfesor(profesorid.Value);  }
            else
            {
                profesor =new Profesor();
            }
            if(profesor==null)
            {
                return RedirectToPage("./Profesores");
            }else 
            {
                return Page();
            }
        
        }
        public IActionResult OnPost()
        {   if (!ModelState.IsValid)
        {
            return Page();
        }else
        {
           if(profesor.id>0)
            {
                _repoProfesor.UpdateProfesor(profesor);

            }
            else{
                _repoProfesor.AddProfesor(profesor);
            } 
        }
            
            return RedirectToPage("./Profesores");
        }
    }

=======
        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());
        [BindProperty]
        public Restaurante registro{get;set;}
        public IActionResult OnGet(int? IdRegistro)
        {
            if (IdRegistro.HasValue)
            {
                registro=_repoRestaurante.GetRegistro(IdRegistro.Value);
            }else
            {
                registro= new Restaurante();
            }
            
            if (registro==null)
            {
                return RedirectToPage("./RegistrosRestaurante");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (registro.Id>0)
            {
                _repoRestaurante.UpdateRegistro(registro);
                
            }else
            {
                _repoRestaurante.AddRegistro(registro);
            }
            
            return RedirectToPage("./RegistrosRestaurante");
        }
    }
>>>>>>> 93413183007c681deb60033ac475aed98e2d5830
}
