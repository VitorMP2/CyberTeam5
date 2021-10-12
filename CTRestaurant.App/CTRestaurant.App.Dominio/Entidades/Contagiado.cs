using System;

namespace CTRestaurant.App.Dominio
{
    public class Contagiado

    {
        public int Id { get; set; }
        public string Sintomas { get; set; }
        public DateTime FechaDiagnostico { get; set; }
        public string PeriodoAislamiento { get; set; }
        public Persona PersonaContagiada{get;set;}

    }
}