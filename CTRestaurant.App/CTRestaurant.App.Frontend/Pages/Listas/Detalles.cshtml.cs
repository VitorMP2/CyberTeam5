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
        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());

        public Restaurante registroRestaurante{get;set;}
        public IActionResult OnGet(int IdRegistro)
        {
            
            registroRestaurante = _repoRestaurante.GetRegistro(IdRegistro);
            
            if(registroRestaurante==null)
            {
                return RedirectToPage("./RegistrosRestaurante");
            }
            return Page();
        }
    }
}
