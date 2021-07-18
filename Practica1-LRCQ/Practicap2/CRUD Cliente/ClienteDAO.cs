using Practicap2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicap2.CRUD_Cliente
{
    public class ClienteDAO
    {
        public void ListaCliente()
        {

            Console.Clear();
            List<tbCliente> listaCli = new List<tbCliente>();
            using (var db = new conDB_EF())
            {
                listaCli = db.tbCliente.ToList();
            }
            Console.WriteLine("Lista de Cliente");
            foreach (var item in listaCli)
            {
                Console.WriteLine(item.idCliente + "\t" + item.nombreCliente + "\t" + item.apellidosCliente + "\t" + item.fechaNacimiento +"\t" + item.dniCliente);
            }
        }
        public void RegistraCliente()
        {
            Console.Clear();
            Console.WriteLine("Registrar Nombre");
            Console.Write("\nIngrese nombre Cliente: ");
            string nombreCli = Console.ReadLine();
            Console.Write("\nIngrese apellido Cliente: ");
            string apellidoCli = Console.ReadLine();
            Console.Write("\nIngrese fecha Cliente: ");
            DateTime fechaCli = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nIngrese dni Cliente: ");
            string dniCli = Console.ReadLine();
            tbCliente cliente = new tbCliente { nombreCliente = nombreCli, apellidosCliente=apellidoCli, fechaNacimiento=fechaCli, dniCliente=dniCli };
            using (var db = new conDB_EF())
            {
                db.tbCliente.Add(cliente);
                db.SaveChanges();
            }
            Console.WriteLine("Se registró correctamente");
        }

        public void EditarCliente()
        {
            Console.Clear();
            ListaCliente();
            Console.Write("\nIngrese el ID del cliente a editar: ");
            int idCli = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nQue desea editar: ");
            Console.Write("\n1.Nombre");
            Console.Write("\n2.Apellido");
            Console.Write("\n3.Fecha");
            Console.Write("\n4.Dni");
            Console.Write("\nIngrese el numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string rpta = "N";
            do
            {
                switch (num)
                {
                    case 1:
                        Console.Write("\nIngrese el nuevo nombre: ");
                        string nombreCli = Console.ReadLine();
                        using (var db = new conDB_EF())
                        {
                            tbCliente cli = db.tbCliente.Find(idCli);
                            cli.nombreCliente = nombreCli;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idCli + " se editó correctamente.");
                        }
                        break;
                    case 2:
                        Console.Write("\nIngrese el nuevo Apellido: ");
                        string apeCli = Console.ReadLine();
                        using (var db = new conDB_EF())
                        {
                            tbCliente cli = db.tbCliente.Find(idCli);
                            cli.apellidosCliente = apeCli;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idCli + " se editó correctamente.");
                        }
                        break;
                    case 3:
                        Console.Write("\nIngrese la nueva fecha: ");
                        DateTime fechCli = Convert.ToDateTime(Console.ReadLine());
                        using (var db = new conDB_EF())
                        {
                            tbCliente cli = db.tbCliente.Find(idCli);
                            cli.fechaNacimiento = fechCli;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idCli + " se editó correctamente.");
                        }
                        break;
                    case 4:
                        Console.Write("\nIngrese el nuevo DNI: ");
                        string dniCli = Console.ReadLine();
                        using (var db = new conDB_EF())
                        {
                            tbCliente cli = db.tbCliente.Find(idCli);
                            cli.dniCliente = dniCli;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idCli + " se editó correctamente.");
                        }
                        break;
                    default:
                        Console.WriteLine("Valor ingresado incorrecto");
                        Console.Write("¿Desea continuar? (S/N)");
                        rpta = Console.ReadLine();
                        break;
                }
            } while (rpta == "S" || rpta == "s");
        }
    }
}
