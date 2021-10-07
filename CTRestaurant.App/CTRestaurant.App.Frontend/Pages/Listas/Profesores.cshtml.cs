using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CTRestaurant.App.Persistencia;
using CTRestaurant.App.Dominio;


namespace CTRestaurant.App.Fronted.Pages
{
    public class ProfesoresModel : PageModel
    {   
        private static IRepositorioProfesor _repoProfesor=new RepositorioProfesor(new Persistencia.AppContext());
        public IEnumerable<Profesor> Profesores {get;set;}
        public void OnGet()
        {
            Profesores =_repoProfesor.GetAllProfesores();
        }
    }
}
