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
        private static IRepositorioAdministrativo _repoAdministrativo = new RepositorioAdministrativo(new Persistencia.AppContext());
        [BindProperty]
        public Administrativo administrativo { get; set; }
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        [BindProperty]
        public Estudiante estudiante { get; set; }
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        [BindProperty]
        public PersonalAseo personalAseo { get; set; }
        private static IRepositorioPersonalCocina _repoPersonalCocina = new RepositorioPersonalCocina(new Persistencia.AppContext());
        [BindProperty]
        public PersonalCocina personalCocina { get; set; }

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
                case 3:
                    administrativo = _repoAdministrativo.GetAdministrativo(Id);
                    return Page();    
                     case 4:
                    estudiante = _repoEstudiante.GetEstudiante(Id);
                    return Page();   
                    case 5:
                    personalAseo = _repoPersonalAseo.GetPersonalAseo(Id);
                    return Page(); 
                      case 6:
                    personalCocina = _repoPersonalCocina.GetPersonalCocina(Id);
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
                case 3:
                    _repoAdministrativo.DeleteAdministrativo(administrativo.id);
                    return RedirectToPage("./Administrativos");
                case 4:
                    _repoEstudiante.DeleteEstudiante(estudiante.id);
                    return RedirectToPage("./Estudiantes");
                case 5:
                    _repoPersonalAseo.DeletePersonalAseo(personalAseo.id);
                    return RedirectToPage("./PersonalAseo");
                  case 6:
                    _repoPersonalCocina.DeletePersonalCocina(personalCocina.id);
                    return RedirectToPage("./PersonalCocina");
                default:
                    return Page();
            }
        }
    }
}

