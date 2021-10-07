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
    public class DetallesModel : PageModel
    {
<<<<<<< HEAD
        private static IRepositorioProfesor _repoProfesor =new RepositorioProfesor(new Persistencia.AppContext());
        public Profesor profesor{get;set;}
        public IActionResult OnGet(int profesoridentificacion)
        {
            
            profesor= _repoProfesor.GetProfesor(profesoridentificacion);
           
            if (profesor==null)
            {
                return  RedirectToPage("./Profesores");
=======
        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());

        public Restaurante registroRestaurante{get;set;}
        public IActionResult OnGet(int IdRegistro)
        {
            
            registroRestaurante = _repoRestaurante.GetRegistro(IdRegistro);
            
            if(registroRestaurante==null)
            {
                return RedirectToPage("./RegistrosRestaurante");
>>>>>>> 93413183007c681deb60033ac475aed98e2d5830
            }
            return Page();
        }
    }
}
