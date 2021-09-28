using System;

namespace CTRestaurant.App.Dominio
{
    public class PersonalCocina : Persona
    {
        //public int Id{get;set;}  Las entidades que heredan no llevan Id
        public int Turno_servcio_cocina{get;set;}
   

    }
}
