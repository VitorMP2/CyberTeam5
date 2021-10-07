using System;

namespace CTRestaurant.App.Dominio
{
    public class Turno
    {
        public int Id{get;set;}
        public DateTime FechaRegistro{get;set;}
        public string Menu{get;set;}
        public DateTime HorarioAsistencia{get;set;}
        public Persona Cliente{get;set;}
    }
}
