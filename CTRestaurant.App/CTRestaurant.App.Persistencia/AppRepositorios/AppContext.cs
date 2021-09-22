using Microsoft.EntityFrameworkCore;
using CTRestaurant.App.Dominio;

namespace CTRestaurant.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas{get;set;}
        public DbSet<Estudiante> Estudiantes{get;set;}
    }
}