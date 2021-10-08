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
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        public Profesor profesor { get; set; }

        /*public IActionResult OnGet(int profesorid)

        {
            profesor = _repoProfesor.GetProfesor(profesorid);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoProfesor.DeleteProfesor(profesor.id);
            return RedirectToPage("./Profesores");
        }*/
        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());
        [BindProperty]
        public Restaurante registro { get; set; }
        public int item = 0;
        public IActionResult OnGet(int Id, int item)
        {
            this.item = item;
            switch (item)
            {
                case 1:
                    profesor = _repoProfesor.GetProfesor(Id);
                    return Page();
                case 2:
                    registro = _repoRestaurante.GetRegistro(Id);
                    return Page();
                default:
                    return Page();
            }
        }
        public IActionResult OnPost(int item)
        {
            this.item = item;
            switch (item)
            {
                case 1:
                    _repoProfesor.DeleteProfesor(profesor.id);
                    return RedirectToPage("./Profesores");
                case 2:
                    _repoRestaurante.DeleteRegistro(registro.Id);
                    return RedirectToPage("./RegistrosRestaurante");
                default:
                    return Page();
            }
        }
    }
}

