using System;

namespace CTRestaurant.App.Dominio
{
    public class Restaurante
    {
        public int Id{get;set;}
        public DateTime FechaRegistro{get;set;}
        public int Aforo{get;set;}
        public int CantidadMesas{get;set;}
        public int PuestosPorMesa{get;set;}

    }
}
