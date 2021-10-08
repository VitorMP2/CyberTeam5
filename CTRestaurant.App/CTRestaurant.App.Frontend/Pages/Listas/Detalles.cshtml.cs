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
        /*public IActionResult OnGet(int profesoridentificacion)
        {
            
            profesor= _repoProfesor.GetProfesor(profesoridentificacion);
        
            if (profesor==null)
            {
                return  RedirectToPage("./Profesores");
            }
        }*/
        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());
        public int item=0;
        public Restaurante registroRestaurante { get; set; }
        public IActionResult OnGet(int Id, int item)
        {
            this.item=item;
            switch (item)
            {
                case 2:
                    registroRestaurante = _repoRestaurante.GetRegistro(Id);

                    if (registroRestaurante == null)
                    {
                        return RedirectToPage("./RegistrosRestaurante");
                    }
                    return Page();
                case 1:
                    profesor= _repoProfesor.GetProfesor(Id);
        
                    if (profesor==null)
                    {
                        return  RedirectToPage("./Profesores");
                    }
                    return Page();
                default:
                return Page();
            }
            
        }
    }
}
