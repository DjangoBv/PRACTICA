using System;
using Practicap2.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicap2.CRUD_Cliente;
using Practicap2.CRUD_Pais;

namespace Practicap2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteDAO cliDAO = new ClienteDAO();
            PaisDAO paDAO = new PaisDAO();
            TarjetaDAO tarDAO = new TarjetaDAO();
            string rpta = "N";
            int codMenu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("MANTENIMIENTO");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1-Cliente");
                Console.WriteLine("2-Pais");
                Console.WriteLine("3-Tarjeta");
                Console.WriteLine("\n0-Salir");
                Console.Write("Ingrese el numero:");
                codMenu = Convert.ToInt32(Console.ReadLine());
                switch (codMenu)
                {
                    case 1:
                        Console.Clear();
                        int cod = 0;
                        Console.WriteLine("1-Lista");
                        Console.WriteLine("2-Registro");
                        Console.WriteLine("3-Editar");
                        Console.Write("Ingrese el numero:");
                        cod = Convert.ToInt32(Console.ReadLine());
                        switch (cod)
                        {
                            case 1:
                                cliDAO.ListaCliente();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine(); break;

                            case 2:
                                cliDAO.RegistraCliente();
                                cliDAO.ListaCliente();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine(); break;
                            case 3:
                                cliDAO.EditarCliente();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Gracias");
                                rpta = "N";
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        int cod1 = 0;
                        Console.WriteLine("1-Lista");
                        Console.WriteLine("2-Registro");
                        Console.WriteLine("3-Editar");
                        Console.Write("Ingrese el numero:");
                        cod1 = Convert.ToInt32(Console.ReadLine());
                        switch (cod1)
                        {
                            case 1:
                                paDAO.ListaPais();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine(); break;
                            case 2:
                                paDAO.RegistraPais();
                                paDAO.ListaPais();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine(); break;
                            case 3:
                                paDAO.EditarPais();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Gracias");
                                rpta = "N";
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        int cod2 = 0;
                        Console.WriteLine("1-Lista");
                        Console.WriteLine("2-Registro");
                        Console.WriteLine("3-Editar");
                        Console.Write("Ingrese el numero:");
                        cod2 = Convert.ToInt32(Console.ReadLine());
                        switch (cod2)
                        {
                            case 1:
                                tarDAO.ListaTarjeta();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine(); break;
                            case 2:
                                tarDAO.RegistraTarjeta();
                                tarDAO.ListaTarjeta();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine(); break;
                            case 3:
                                tarDAO.EditarTarjeta();
                                Console.Write("¿Desea continuar?(S/N)");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Gracias");
                                rpta = "N";
                                break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Gracias");
                        rpta = "N";
                        break;
                    default:
                        Console.WriteLine("Valor ingresado incorrecto");
                        Console.Write("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                }
            } while (rpta == "S" || rpta == "s");

            Console.ReadLine();
        }
    }
}
