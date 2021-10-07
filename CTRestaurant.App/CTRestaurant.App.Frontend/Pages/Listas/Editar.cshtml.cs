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
    public class EditarModel : PageModel
    {
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
}
