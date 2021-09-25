using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using LogicaNegocio;

namespace EjercicioPulsaciones
{
    class Program
    {
        static void Main(string[] args)
        {
                string sexo,identidad,nombres,buscar, mensaje;
                int edad, x, OpcionSeleccionada = 0; 
                Estudiante estudiante;  ConsoleKeyInfo opcion;
                List<Estudiante> listaEstudiantes = new List<Estudiante>();
                EstudianteService estudianteService = new EstudianteService();

                while (OpcionSeleccionada != 5)
                {
                    Console.WriteLine("****  Calculos de Pulsos *****");
                    Console.WriteLine("1) Ingresar Datos del estudiante");
                    Console.WriteLine("2) Buscar Datos del estudiante");
                    Console.WriteLine("3) Eliminar Datos del estudiante");
                    Console.WriteLine("4) Modificar Datos del estudiante");
                    Console.WriteLine("5) Salir del programa");
                    Console.WriteLine("*************************************");
                    Console.Write("Ingrese una opcion ->: ");

                    string opcionTemporal = Console.ReadLine();

                    if (int.TryParse(opcionTemporal, out x))
                    {
                        OpcionSeleccionada = int.Parse(opcionTemporal);

                        switch (OpcionSeleccionada)
                        {

                            case 1:

                                do
                                {
                                    try
                                    {

                                        Console.Clear();
                                        Console.WriteLine("***  Digite los Datos del Estudiante:  ***");
                                        Console.WriteLine("Digite la Identidad:");
                                        identidad = Console.ReadLine();

                                        Console.WriteLine("Digite los Nombres:");
                                        nombres = Console.ReadLine();

                                        Console.WriteLine("Digite la Edad:");
                                        edad = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite el Sexo ->(F o M):");
                                        sexo = Console.ReadLine();

                                        estudiante = new Estudiante(identidad, nombres, edad, sexo);
                                        estudiante.CalcularPulsosEstudiantes();
                                        Console.WriteLine(estudianteService.Guardar(estudiante));

                                        listaEstudiantes.Add(estudiante);

                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Por favor verifique los datos ingresados " + e.Message);
                                    }

                                    Console.WriteLine("Quiere seguir registrando estudiantes (S/N)");
                                    opcion = Console.ReadKey();
                                    Console.ReadKey();
                                } while (opcion.Key == ConsoleKey.S);
                                  Console.Clear();
                                break;


                            case 2:
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("***  Ingrese La Identidad que quiere Buscar:  ***");
                                    buscar = Console.ReadLine();
                                    estudianteService.Buscar(buscar);
                                    Console.WriteLine(estudianteService.Buscar(buscar));
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Por favor verifique los datos ingresados " + e.Message);
                                }
                                Console.WriteLine("los datos que quiere buscar no existen ");
                                Console.WriteLine("Quiere seguir consultando estudiantes (S/N)");
                                opcion = Console.ReadKey();
                                Console.ReadKey();
                            } while (opcion.Key == ConsoleKey.S);
                            Console.Clear();
                            break;


                            case 3:
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("***  Ingrese La Identidad que quiere Eliminar:  ***");
                                    buscar = Console.ReadLine();
                                    mensaje = estudianteService.Eliminar(estudianteService.Buscar(buscar));
                                    Console.WriteLine(mensaje);
                                    Console.Clear();
                                    Console.WriteLine("los datos del estudiante son: ");
                                    foreach (var itemPersona in estudianteService.Consultar())
                                    {
                                        Console.WriteLine(itemPersona.ToString());
                                    }
                                }
                                catch (Exception e)
                                {

                                    Console.WriteLine("Por favor verifique los datos ingresados " + e.Message);
                                }
                                Console.WriteLine("los datos del estudiante que quiere eliminar no existen");
                                Console.WriteLine("Quiere seguir Eliminando estudiantes (S/N)");
                                opcion = Console.ReadKey();
                                Console.ReadKey();
                            } while (opcion.Key == ConsoleKey.S);
                               Console.Clear();
                                break;


                            case 4:
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Digite la info del estudiante a modificar: ");
                                    string IdentificacionBuscada = Console.ReadLine();
                                    Estudiante estudianteantiguo = estudianteService.Buscar(IdentificacionBuscada);
                                    Console.WriteLine(estudianteantiguo.ToString());
                                    Console.WriteLine("***  Digite los Siguientes Datos:  ***");

                                    identidad = estudianteantiguo.Identificacion;

                                    Console.WriteLine("Digite los Nombres:");
                                    nombres = Console.ReadLine();

                                    Console.WriteLine("Digite la Edad:");
                                    edad = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite el Sexo(F o M)->:");
                                    sexo = Console.ReadLine();

                                    Estudiante estudiantemodificado = new Estudiante(identidad, nombres, edad, sexo);
                                    estudiantemodificado.CalcularPulsosEstudiantes();
                                    estudianteService.Modificar(estudiantemodificado);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Por favor verifique los datos ingresados " + e.Message);
                                }
                                Console.WriteLine("los datos del estudiante que quiere modificar no existen ");
                                Console.WriteLine("Quiere seguir Modificando estudiantes (S/N)");
                                opcion = Console.ReadKey();
                                Console.ReadKey();
                            } while (opcion.Key == ConsoleKey.S);
                            Console.Clear();
                                break;
                            case 5:

                                break;
                        }
                    }

                }
        }
        
    }
}
