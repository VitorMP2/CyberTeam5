using System;
using System .ComponentModel.DataAnnotations;

namespace CTRestaurant.App.Dominio
{
	public class Persona
	{
		public int id{get;set;}
		[Required] 
		public string nombre{get;set;}
		[Required]
		public string apellido{get;set;}
		[Range (1,1053999999)]
		public int identificacion{get;set;}
		public int edad{get;set;}
		public EstadoCOVID estadoCovid{get;set;}
	}
}
