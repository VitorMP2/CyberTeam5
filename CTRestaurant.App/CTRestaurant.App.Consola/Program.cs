using System;
using CTRestaurant.App.Dominio;
using CTRestaurant.App.Persistencia;

namespace CTRestaurant.App.Consola
{
    class Program
    {   
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CrearProfesor();
            //ConsultarProfesor(1000000);
            EditarProfesor();
            
         /*   Profesor profesor_1= new Profesor
            {
                nombre ="Santiago",
                apellido="Quintero",
                identificacion=1000000,
                edad=30,
                estadoCovid=EstadoCOVID.Positivo,
                Cubiculo="03",
                Facultad="Ingenieria"

             };
             Console.WriteLine(profesor_1.nombre+" "+profesor_1.apellido+"\n"+profesor_1.identificacion+"\n"+profesor_1.edad+"\n"+profesor_1.estadoCovid+"\n"+profesor_1.Cubiculo+"\n"+profesor_1.Facultad);
*/
        }
        //CRUD
        //CrearProfesor
        private static void CrearProfesor()
        {
             var profesor = new Profesor
             {
                  nombre ="Felipe",
                apellido="Mesa",
                identificacion=100000,
                edad=30,
                estadoCovid=EstadoCOVID.Positivo,
                Cubiculo="03",
                Facultad="Ingenieria"
             };
            Profesor profesorGuardado  =_repoProfesor.AddProfesor(profesor);
            if (profesorGuardado!=null)
            Console.WriteLine("Se registro un profesor con exito");
            else 

            {
                 Console.WriteLine("Hubo un error de conexion con la base de datos");     
            }
        }
        //ConsultarProfesor
        private static void ConsultarProfesor(int identificacion)
        {
           Profesor profesorEncontrado= _repoProfesor.GetProfesor(identificacion); 
           if (profesorEncontrado!=null)

           Console.WriteLine(profesorEncontrado.nombre);
           else
           {
               Console.WriteLine("Profesor no encontrado");
           }
        }
        //EditarProfesor
        private static void EditarProfesor()
        {
            var profesor = new Profesor
             {
                  nombre ="Felipe",
                apellido="Mesa",
                identificacion=1000001,
                edad=30,
                estadoCovid=EstadoCOVID.Positivo,
                Cubiculo="03",
                Facultad="Derecho"
             }; 
             var profesorActualizado= _repoProfesor.UpdateProfesor(profesor);
             if (profesorActualizado!=null)
             {
                 Console.WriteLine("Se actualizo el profesor correctamente con identificacion"+profesorActualizado.identificacion);

             }else
             {
                 Console.WriteLine("No se encontro el profesor que se iba actalizar");
             }
        }
        //EliminarProfesor
        //ConsultarProfesores
    }
}
