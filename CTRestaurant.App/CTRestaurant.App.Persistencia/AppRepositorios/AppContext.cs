using Microsoft.EntityFrameworkCore;
using CTRestaurant.App.Dominio;

namespace CTRestaurant.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas{get;set;}
        public DbSet<Estudiante> Estudiantes{get;set;}
        public DbSet<Administrativo> Administrativos {get;set;}
        public DbSet<Contagiado> Contagiado {get;set;}
        public DbSet<PersonalAseo> PersonalAseo {get;set;}
        public DbSet<PersonalCocina> PersonalCocina {get;set;}
        public DbSet<Profesor> Profesores {get;set;}
        public DbSet<Restaurante> Restaurante {get;set;}
        public DbSet<Turno> Turno {get;set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
        if (!optionsbuilder.IsConfigured)
        optionsbuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = CTRestaurant");
        }
    }
}