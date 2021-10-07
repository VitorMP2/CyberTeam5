using System.Collections;
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
    public class RegistrosRestauranteModel : PageModel
    {
        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());
        //public Restaurante RegistrosRestaurante{get;set;}
        public IEnumerable<Restaurante> RegistrosRestaurante {get;set;}

        public void OnGet()
        {
            RegistrosRestaurante=_repoRestaurante.GetAllRestaurante();
            
        }
    }
}
