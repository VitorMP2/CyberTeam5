using System;
using CTRestaurant.App.Dominio;
using CTRestaurant.App.Persistencia;
using System.Collections.Generic;

namespace CTRestaurant.App.Consola
{
    class Program
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        private static IRepositorioAdministrativo _repoAdministrativo = new RepositorioAdministrativo(new Persistencia.AppContext());
        private static IRepositorioContagiado _repoContagiado = new RepositorioContagiado(new Persistencia.AppContext());
        private static IRepositorioRestaurante _repoRestaurante = new RepositorioRestaurante(new Persistencia.AppContext());
        private static IRepositorioTurno _repoTurno = new RepositorioTurno(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CrearProfesor();
            //ConsultarProfesor(1000000);
            //EliminarProfesor(100000);
            //ConsultarProfesores();
            //-------------------------------------------------------
            //CrearAdministrativo();
            //ConsultarAdministrativo();
            //EliminarAdministrativo();
            //ConsultarAdministrativos();
            //-------------------------------------------------------
            //CrearEstudiante();
            //ConsultarEstudiante();
            //EliminarEstudiante();
            //ConsultarEstudiantes();
            //-------------------------------------------------------
            //CrearContagiado();
            //ConsultarContagiado();
            //EliminarContagiado();
            //ConsultarContagiados();
            //-------------------------------------------------------
            //CrearRegistroRestaurante();
            //ConsultarRegistroRestaurante();
            //EliminarRegistroRestaurante();
            //ConsultarRegistrosRestaurante();
            //-------------------------------------------------------
            //CrearTurno();
            //ConsultarTurno();
            //ConsultarTurnoCliente(3);
            //EliminarTurno();
            //ConsultarTurnos();
            //#########################################################
            //AsignarClienteTurno(10, ConsultarPersona(15435645), "Tortillas");

        }

        //CRUD Profesor----------------------------------------------------------------------------------
        //CrearProfesor
        private static void CrearProfesor()
        {
            var profesor = new Profesor
            {
                nombre = "Catalina",
                apellido = "Suarez",
                identificacion = 3445525,
                edad = 28,
                estadoCovid = EstadoCOVID.Negativo,
                Cubiculo = "10",
                Facultad = "Derecho"
            };
            Profesor profesorGuardado = _repoProfesor.AddProfesor(profesor);
            if (profesorGuardado != null)
                Console.WriteLine("Se registro un profesor con éxito");
            else

            {
                Console.WriteLine("Hubo un error de conexion con la base de datos");
            }
        }
        //ConsultarProfesor
        private static Profesor ConsultarProfesor(int identificacion)
        {
            Profesor profesorEncontrado = _repoProfesor.GetProfesor(identificacion);
            if (profesorEncontrado != null)
            {
                Console.WriteLine("Profesor " + profesorEncontrado.nombre + " " + profesorEncontrado.apellido);
            }
            else
            {
                Console.WriteLine("Profesor no encontrado");
            }
            return profesorEncontrado;
        }
        //EditarProfesor
        private static void EditarProfesor()
        {
            var profesor = new Profesor
            {
                nombre = "Felipe",
                apellido = "Mesa",
                identificacion = 1000001,
                edad = 30,
                estadoCovid = EstadoCOVID.Positivo,
                Cubiculo = "03",
                Facultad = "Derecho"
            };
            var profesorActualizado = _repoProfesor.UpdateProfesor(profesor);
            if (profesorActualizado != null)
            {
                Console.WriteLine("Se actualizo el profesor correctamente con identificacion" + profesorActualizado.identificacion);

            }
            else
            {
                Console.WriteLine("No se encontro el profesor");
            }
        }
        // EliminarProfesor
        private static void EliminarProfesor(int identificacion)
        {
            if (_repoProfesor.DeleteProfesor(identificacion))
                Console.WriteLine("Profesor Eliminado");
            else
            {
                Console.WriteLine("No se pudo eliminar el profesor con esta identificacion, verifique que es la identificacion correcta");
            }
        }
        //ConsultarProfesores
        private static void ConsultarProfesores()
        {
            IEnumerable<Profesor> profesores = _repoProfesor.GetAllProfesores();
            foreach (var profesor in profesores)
            {
                Console.WriteLine(profesor.nombre + " " + profesor.apellido + " " + profesor.Facultad);
            }
        }

        //CRUD Administrativo-----------------------------------------------------------------------------------
        //CrearAdministrativo
        private static void CrearAdministrativo()
        {
            var administrativo = new Administrativo
            {
                nombre = "Daniela",
                apellido = "Molina",
                identificacion = 15435645,
                edad = 21,
                estadoCovid = EstadoCOVID.Positivo,
                Oficina = "7"
            };

            Administrativo AdministrativoGuardado = _repoAdministrativo.AddAdministrativo(administrativo);
            if (AdministrativoGuardado != null)
                Console.WriteLine("Se registro un Administrativo con éxito");
            else

            {
                Console.WriteLine("Hubo un error de conexion con la base de datos");
            }
        }
        //ConsultarAdministrativo
        private static Administrativo ConsultarAdministrativo(int identificacion)
        {
            Administrativo AdministrativoEncontrado = _repoAdministrativo.GetAdministrativo(identificacion);
            if (AdministrativoEncontrado != null)
            {
                Console.WriteLine("Administrativo " + AdministrativoEncontrado.nombre + " " + AdministrativoEncontrado.apellido);

            }
            else
            {
                Console.WriteLine("Administrativo no encontrado");

            }
            return AdministrativoEncontrado;
        }
        //EditarAdministrativo
        private static void EditarAdministrativo()
        {
            var Administrativo = new Administrativo
            {
                nombre = "Felipe",
                apellido = "Mesa",
                identificacion = 1000001,
                edad = 30,
                estadoCovid = EstadoCOVID.Positivo,
                Oficina = "2"
            };
            var AdministrativoActualizado = _repoAdministrativo.UpdateAdministrativo(Administrativo);
            if (AdministrativoActualizado != null)
            {
                Console.WriteLine("Se actualizo el Administrativo correctamente con identificacion" + AdministrativoActualizado.identificacion);

            }
            else
            {
                Console.WriteLine("No se encontro el Administrativo");
            }
        }
        // EliminarAdministrativo
        private static void EliminarAdministrativo(int identificacion)
        {
            if (_repoAdministrativo.DeleteAdministrativo(identificacion))
                Console.WriteLine("Administrativo Eliminado");
            else
            {
                Console.WriteLine("No se pudo eliminar el Administrativo con esta identificacion, verifique que es la identificacion correcta");
            }
        }
        //ConsultarAdministrativos
        private static void ConsultarAdministrativos()
        {
            IEnumerable<Administrativo> Administrativos = _repoAdministrativo.GetAllAdministrativos();
            foreach (var administrativo in Administrativos)
            {
                Console.WriteLine(administrativo.nombre + " " + administrativo.apellido + " " + administrativo.Oficina);
            }
        }
        //CRUD Estudiante-----------------------------------------------------------------------------------
        //CrearEstudiante
        private static void CrearEstudiante()
        {
            var Estudiante = new Estudiante
            {
                nombre = "Andres",
                apellido = "Hernandez",
                identificacion = 123342645,
                edad = 22,
                estadoCovid = EstadoCOVID.Negativo,
                Programa = "Biología"
            };

            Estudiante EstudianteGuardado = _repoEstudiante.AddEstudiante(Estudiante);
            if (EstudianteGuardado != null)
                Console.WriteLine("Se registro {Estudiante.nombre} {Estudiante.apellido} con éxito");
            else

            {
                Console.WriteLine("Hubo un error de conexion con la base de datos");
            }
        }
        //ConsultarEstudiante
        private static Estudiante ConsultarEstudiante(int identificacion)
        {
            Estudiante EstudianteEncontrado = _repoEstudiante.GetEstudiante(identificacion);
            if (EstudianteEncontrado != null)
            {
                Console.WriteLine("Estudiante " + EstudianteEncontrado.nombre + " " + EstudianteEncontrado.apellido);

            }
            else
            {
                Console.WriteLine("Estudiante no encontrado");

            }
            return EstudianteEncontrado;
        }
        //EditarEstudiante
        private static void EditarEstudiante()
        {
            var Estudiante = new Estudiante
            {
                nombre = "Felipe",
                apellido = "Mesa",
                identificacion = 1000001,
                edad = 30,
                estadoCovid = EstadoCOVID.Positivo,
                Programa = "Ingeniería"
            };
            var EstudianteActualizado = _repoEstudiante.UpdateEstudiante(Estudiante);
            if (EstudianteActualizado != null)
            {
                Console.WriteLine("Se actualizo el Estudiante correctamente con identificacion" + EstudianteActualizado.identificacion);

            }
            else
            {
                Console.WriteLine("No se encontro el Estudiante");
            }
        }
        // EliminarEstudiante
        private static void EliminarEstudiante(int identificacion)
        {
            if (_repoEstudiante.DeleteEstudiante(identificacion))
                Console.WriteLine("Estudiante Eliminado");
            else
            {
                Console.WriteLine("No se pudo eliminar el Estudiante con esta identificacion, verifique que es la identificacion correcta");
            }
        }
        //ConsultarEstudiantes
        private static void ConsultarEstudiantes()
        {
            IEnumerable<Estudiante> Estudiantes = _repoEstudiante.GetAllEstudiantes();
            foreach (var estudiante in Estudiantes)
            {
                Console.WriteLine(estudiante.nombre + " " + estudiante.apellido + " " + estudiante.Programa);
            }
        }
        //CRUD Contagiado-----------------------------------------------------------------------------------
        //CrearContagiado
        private static void CrearContagiado(Persona Cliente)
        {
            var contagiado = new Contagiado
            {
                PeriodoAislamiento = "15 días",
                FechaDiagnostico = DateTime.Now
            };
            _repoContagiado.AddContagiado(contagiado);
            Contagiado ContagiadoGuardado=_repoContagiado.GetUltimoContagiado();
            ContagiadoGuardado.PersonaContagiada = Cliente;
            _repoContagiado.UpdateContagiado(ContagiadoGuardado);

            if (ContagiadoGuardado != null)
                Console.WriteLine("Se registró el Clinte en la sección de contagiados");
            else

            {
                Console.WriteLine("Hubo un error de conexion con la base de datos");
            }
        }
        //ConsultarContagiado
        private static void ConsultarContagiado(int Id)
        {
            Contagiado ContagiadoEncontrado = _repoContagiado.GetContagiado(Id);
            if (ContagiadoEncontrado != null)

                Console.WriteLine(ContagiadoEncontrado.PersonaContagiada.id);
            else
            {
                Console.WriteLine("Contagiado no encontrado");
            }
        }
        //EditarContagiado
        private static void EditarContagiado(Persona Cliente)
        {
            var Contagiado = new Contagiado
            {
                
                PeriodoAislamiento = "15 días",
                FechaDiagnostico = DateTime.Now
            };
            var ContagiadoActualizado = _repoContagiado.UpdateContagiado(Contagiado);
            if (ContagiadoActualizado != null)
            {
                Console.WriteLine("Se actualizo el Contagiado correctamente con id" + ContagiadoActualizado.Id);

            }
            else
            {
                Console.WriteLine("No se encontro el Contagiado");
            }
        }
        // EliminarContagiado
        private static void EliminarContagiado(int Id)
        {
            if (_repoContagiado.DeleteContagiado(Id))
                Console.WriteLine("Contagiado Eliminado");
            else
            {
                Console.WriteLine("No se pudo eliminar el Contagiado con esta id, verifique que es la identificacion correcta");
            }
        }
        //ConsultarContagiados
        private static void ConsultarContagiados()
        {
            IEnumerable<Contagiado> Contagiados = _repoContagiado.GetAllContagiados();
            foreach (var contagiado in Contagiados)
            {
                Console.WriteLine(contagiado.PersonaContagiada.id + " " + contagiado.FechaDiagnostico.ToShortDateString() + " " + contagiado.PeriodoAislamiento);
            }
        }
        //CRUD Turno-----------------------------------------------------------------------------------
        //CrearTurno
        private static void CrearTurno()
        {
            var turno = new Turno
            {
                FechaRegistro = DateTime.Now.AddDays(-1),
                Menu = "Carne Asada",
                HorarioAsistencia = DateTime.Now.AddDays(-1)
            };

            Turno TurnoGuardado = _repoTurno.AddTurno(turno);
            if (TurnoGuardado != null)
                Console.WriteLine("Se registro un Turno con éxito");
            else

            {
                Console.WriteLine("Hubo un error de conexion con la base de datos");
            }
        }
        //ConsultarTurno
        private static void ConsultarTurno(int Id)
        {
            Turno TurnoEncontrado = _repoTurno.GetTurno(Id);
            if (TurnoEncontrado != null)

                Console.WriteLine(TurnoEncontrado.Menu);
            else
            {
                Console.WriteLine("Turno no encontrado");
            }
        }
        //Consultar Turno con información del Cliente
        private static Turno ConsultarTurnoCliente(int Id)
        {
            Turno TurnoEncontrado = _repoTurno.GetTurnoCliente(Id);
            if (TurnoEncontrado != null)
            {

                Console.WriteLine(TurnoEncontrado.Menu);
                Console.WriteLine(TurnoEncontrado.HorarioAsistencia);
                Console.WriteLine(TurnoEncontrado.Cliente.nombre);
                Console.WriteLine(TurnoEncontrado.Cliente.apellido);
            }
            else
            {
                Console.WriteLine("Turno no encontrado");
            }
            return TurnoEncontrado;
        }
        //EditarTurno
        private static void EditarTurno()
        {
            var Turno = new Turno
            {
                FechaRegistro = DateTime.Now,
                Menu = "Spaguetti",
                HorarioAsistencia = DateTime.Now
            };
            var TurnoActualizado = _repoTurno.UpdateTurno(Turno);
            if (TurnoActualizado != null)
            {
                Console.WriteLine("Se actualizo el Turno correctamente con id" + TurnoActualizado.Id);

            }
            else
            {
                Console.WriteLine("No se encontro el Turno");
            }
        }
        // EliminarTurno
        private static void EliminarTurno(int Id)
        {
            if (_repoTurno.DeleteTurno(Id))
                Console.WriteLine("Turno Eliminado");
            else
            {
                Console.WriteLine("No se pudo eliminar el Turno con esta id, verifique que es la identificacion correcta");
            }
        }
        //ConsultarTurnos
        private static void ConsultarTurnos()
        {
            IEnumerable<Turno> Turnos = _repoTurno.GetAllTurno();
            foreach (var Turno in Turnos)
            {
                Console.WriteLine(Turno.FechaRegistro.ToShortDateString() + "\t" + Turno.HorarioAsistencia.ToShortTimeString() + "\t" + Turno.Menu/*+ Turno.Cliente*/);
            }
        }
        //CRUD RegistroRestaurante-----------------------------------------------------------------------------------
        //CrearRegistroRestaurante
        private static void CrearRegistroRestaurante()
        {
            var RegistroRestaurante = new Restaurante
            {
                FechaRegistro = DateTime.Now.AddDays(1),
                Aforo = 30,
                CantidadMesas = 9,
                PuestosPorMesa = 4
            };

            Restaurante RegistroGuardado = _repoRestaurante.AddRegistro(RegistroRestaurante);
            if (RegistroGuardado != null)
                Console.WriteLine("Se registro un Registro con éxito");
            else

            {
                Console.WriteLine("Hubo un error de conexion con la base de datos");
            }
        }
        //ConsultarRegistro
        private static void ConsultarRegistro(int Id)
        {
            Restaurante RegistroEncontrado = _repoRestaurante.GetRegistro(Id);
            if (RegistroEncontrado != null)

                Console.WriteLine(RegistroEncontrado);
            else
            {
                Console.WriteLine("Registro no encontrado");
            }
        }
        //EditarRegistro
        private static void EditarRegistro()
        {
            var Registro = new Restaurante
            {
                FechaRegistro = DateTime.Now,
                Aforo = 5,
                CantidadMesas = 7,
                PuestosPorMesa = 5
            };
            var RegistroActualizado = _repoRestaurante.UpdateRegistro(Registro);
            if (RegistroActualizado != null)
            {
                Console.WriteLine("Se actualizo el Registro correctamente con id" + RegistroActualizado.Id);

            }
            else
            {
                Console.WriteLine("No se encontro el Registro");
            }
        }
        // EliminarRegistro
        private static void EliminarRegistro(int Id)
        {
            if (_repoRestaurante.DeleteRegistro(Id))
                Console.WriteLine("Registro Eliminado");
            else
            {
                Console.WriteLine("No se pudo eliminar el Registro con esta id, verifique que es la id correcta");
            }
        }
        //ConsultarRegistros
        private static void ConsultarRegistrosRestaurante()
        {
            IEnumerable<Restaurante> Registros = _repoRestaurante.GetAllRestaurante();
            foreach (var registro in Registros)
            {
                Console.WriteLine(registro.FechaRegistro.ToShortDateString() + "\t" + registro.Turnos);
            }
        }
        //################################################################################################
        //Consultar Persona
        private static Persona ConsultarPersona(int identificacion)
        {

            if (_repoProfesor.GetProfesor(identificacion) != null)
            {
                return ConsultarProfesor(identificacion);
            }
            else
            {
                if (_repoAdministrativo.GetAdministrativo(identificacion) != null)
                {
                    return ConsultarAdministrativo(identificacion);
                }
                else
                {
                    if (_repoEstudiante.GetEstudiante(identificacion) != null)
                    {
                        return ConsultarEstudiante(identificacion);
                    }
                    else
                    {
                        Console.WriteLine("No se encontro a la persona");
                        return null;
                    }
                }
            }

        }
        //Asignar Cliente a un Turno
        private static void AsignarClienteTurno(int IdTurno, Persona Cliente, string Menu)
        {
            if (Cliente != null)
            {
                
                if (Cliente.estadoCovid == EstadoCOVID.Positivo)
                {
                    CrearContagiado(Cliente);
                }
                else
                {
                    Turno turnoEncontrado = _repoTurno.GetTurno(IdTurno);
                    turnoEncontrado.Cliente = Cliente;
                    turnoEncontrado.Menu = Menu;
                    _repoTurno.UpdateTurno(turnoEncontrado);
                    Console.WriteLine("Se asignó correctamente el turno "+turnoEncontrado.FechaRegistro+" a "+Cliente.nombre+" "+Cliente.apellido);
                }
            }
        }
    }
}
