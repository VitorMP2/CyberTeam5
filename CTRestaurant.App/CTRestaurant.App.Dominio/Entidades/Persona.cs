using System;

namespace CTRestaurant.App.Dominio
{
	public class Persona
	{
		public int Id{get;set;}
		public string nombre{get;set;}
		public string apellido{get;set;}
		public int identificacion{get;set;}
		public int edad{get;set;}
		public EstadoCOVID estadoCovid{get;set;}
	}
}
