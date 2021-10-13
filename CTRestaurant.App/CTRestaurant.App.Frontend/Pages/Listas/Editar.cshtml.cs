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
        private static IRepositorioAdministrativo _repoAdministrativo = new RepositorioAdministrativo(new Persistencia.AppContext());
        [BindProperty]
        public Administrativo administrativo { get; set; }
         private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        [BindProperty]
        public Estudiante estudiante { get; set; }
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        [BindProperty]
        public Profesor profesor { get; set; }
         private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        [BindProperty]
        public PersonalAseo personalAseo { get; set; }
         private static IRepositorioPersonalCocina _repoPersonalCocina = new RepositorioPersonalCocina(new Persistencia.AppContext());
        [BindProperty]
        public PersonalCocina personalCocina { get; set; }
        /*public IActionResult OnGet(int? profesorid)
        {
            if (profesorid.HasValue)
            {
                profesor = _repoProfesor.GetProfesor(profesorid.Value);
            }
            else
            {
                profesor = new Profesor();
            }
            if (profesor == null)
            {
                return RedirectToPage("./Profesores");
            }
            else
            {
                return Page();
            }

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (profesor.id > 0)
                {
                    _repoProfesor.UpdateProfesor(profesor);

                }
                else
                {
                    _repoProfesor.AddProfesor(profesor);
                }
            }

            return RedirectToPage("./Profesores");
        }*/


        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());

        public int item = 0;
        [BindProperty]
        public Restaurante registro { get; set; }
        public IActionResult OnGet(int? Id, int item)
        {
            this.item = item;
            switch (item)
            {
                case 1:
                    if (Id.HasValue)
                    {
                        profesor = _repoProfesor.GetProfesor(Id.Value);
                        
                    }
                    else
                    {
                        profesor = new Profesor();
                        
                    }
                    if (profesor == null)
                    {
                        return RedirectToPage("./Profesores");
                    }
                    else
                    {
                        return Page();
                    };
                case 2:

                    if (Id.HasValue)
                    {
                        registro = _repoRestaurante.GetRegistro(Id.Value);
                        
                    }
                    else
                    {
                        registro = new Restaurante();
                        
                    }

                    if (registro == null)
                    {
                        return RedirectToPage("./RegistrosRestaurante");
                    }
                    return Page();
                    case 3:
                    if (Id.HasValue)
                    {
                        administrativo = _repoAdministrativo.GetAdministrativo(Id.Value);
                        
                    }
                    else
                    {
                        administrativo = new Administrativo();
                        
                    }
                    if (administrativo == null)
                    {
                        return RedirectToPage("./Administrativos");
                    }
                    else
                    {
                        return Page();
                    };
                     case 4:
                    if (Id.HasValue)
                    {
                        estudiante = _repoEstudiante.GetEstudiante(Id.Value);
                        
                    }
                    else
                    {
                        estudiante = new Estudiante();
                        
                    }
                    if (estudiante == null)
                    {
                        return RedirectToPage("./Estudiantes");
                    }
                    else
                    {
                        return Page();
                    };
                     case 5:
                    if (Id.HasValue)
                    {
                        personalAseo = _repoPersonalAseo.GetPersonalAseo(Id.Value);
                        
                    }
                    else
                    {
                        personalAseo= new PersonalAseo();
                        
                    }
                    if (personalAseo == null)
                    {
                        return RedirectToPage("./PersonalAseo");
                    }
                    else
                    {
                        return Page();
                    };
                     case 6:
                    if (Id.HasValue)
                    {
                        personalCocina = _repoPersonalCocina.GetPersonalCocina(Id.Value);
                        
                    }
                    else
                    {
                        personalCocina= new PersonalCocina();
                        
                    }
                    if (personalCocina == null)
                    {
                        return RedirectToPage("./PersonalCocina");
                    }
                    else
                    {
                        return Page();
                    };
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
                    /*if (!ModelState.IsValid)
                    {
                        return Page();
                    }
                    else
                    {*/
                        if (profesor.id > 0)
                        {
                            _repoProfesor.UpdateProfesor(profesor);

                        }
                        else
                        {
                            _repoProfesor.AddProfesor(profesor);
                        }
                    //}
                    return RedirectToPage("./Profesores");                    
                case 2:
                    if (registro.Id > 0)
                    {
                        _repoRestaurante.UpdateRegistro(registro);

                    }
                    else
                    {
                        _repoRestaurante.AddRegistro(registro);
                    }

                    return RedirectToPage("./RegistrosRestaurante");   
                    case 3:
                   
                        if (administrativo.id > 0)
                        {
                            _repoAdministrativo.UpdateAdministrativo(administrativo);

                        }
                        else
                        {
                            _repoAdministrativo.AddAdministrativo(administrativo);
                        }
                    //}
                    return RedirectToPage("./Administrativos");    
                    case 4:
                   
                        if (administrativo.id > 0)
                        {
                            _repoEstudiante.UpdateEstudiante(estudiante);

                        }
                        else
                        {
                            _repoEstudiante.AddEstudiante(estudiante);
                        }
                    //}
                    return RedirectToPage("./Estudiantes"); 
                    case 5:
                   
                        if (personalAseo.id > 0)
                        {
                            _repoPersonalAseo.UpdatePersonalAseo(personalAseo);

                        }
                        else
                        {
                            _repoPersonalAseo.AddPersonalAseo(personalAseo);
                        }
                    //}
                    return RedirectToPage("./PersonalAseo"); 
                     case 6:
                   
                        if (personalCocina.id > 0)
                        {
                            _repoPersonalCocina.UpdatePersonalCocina(personalCocina);

                        }
                        else
                        {
                            _repoPersonalCocina.AddPersonalCocina(personalCocina);
                        }
                    //}
                    return RedirectToPage("./PersonalCocina");              
                default:
                    return Page();
            }
        }
    }
}
