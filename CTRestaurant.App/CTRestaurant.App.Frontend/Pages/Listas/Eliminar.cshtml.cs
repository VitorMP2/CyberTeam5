using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTRestaurant.App.Dominio;
using CTRestaurant.App.Persistencia;
namespace CTRestaurant.App.Frontend.Pages
{
    public class EliminarModel : PageModel
    {
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
        }
    }
}
