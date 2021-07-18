using Practicap2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Practicap2.CRUD_Cliente;
using System.Threading.Tasks;

namespace Practicap2.CRUD_Pais
{
    public class TarjetaDAO
    {
        public void ListaTarjeta()
        {
            Console.Clear();
            List<tbTarjeta> listaTar = new List<tbTarjeta>();
            using (var db = new conDB_EF())
            {
                listaTar = db.tbTarjeta.ToList();
            }
            Console.WriteLine("Lista de Tarjeta");
            foreach (var item in listaTar)
            {
                Console.WriteLine(item.idTarjeta + "\t" + item.numeroTarjeta + "\t" + item.tipoTarjeta + "\t" + item.modoPago + "\t" + item.fechaVencimiento + "\t" + item.idCliente);
            }
        }
        public void RegistraTarjeta()
        {
            Console.Clear();
            Console.WriteLine("Registrar Tarjeta");
            Console.Write("\nIngrese numero Tarjeta: ");
            string numeroTarjeta = Console.ReadLine();
            Console.Write("\nIngrese tipo Tarjeta: ");
            string tipTarjeta = Console.ReadLine();
            Console.Write("\nIngrese modo Tarjeta: ");
            string modTarjeta = Console.ReadLine();
            Console.Write("\nIngrese fecha Vencimiento: ");
            string fecTarjeta = Console.ReadLine();
            Console.Write("\nIngrese id Cliente: ");
            int idCliente2 = Convert.ToInt32(Console.ReadLine());
            tbTarjeta Tarjeta = new tbTarjeta { numeroTarjeta = numeroTarjeta, tipoTarjeta=tipTarjeta, modoPago=modTarjeta, fechaVencimiento=fecTarjeta, idCliente = idCliente2};
            using (var db = new conDB_EF())
            {
                db.tbTarjeta.Add(Tarjeta);
                db.SaveChanges();
            }
            Console.WriteLine("Se registró correctamente");
        }

        public void EditarTarjeta()
        {
            Console.Clear();
            ListaTarjeta();
            Console.Write("\nIngrese el ID tarjeta a editar: ");
            int idTarjeta = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nQue desea editar: ");
            Console.Write("\n1.Numero de tarjeta");
            Console.Write("\n2.Tipo de Tarjeta");
            Console.Write("\n3.Modo de pago");
            Console.Write("\n4.fecha de tarjeta");
            Console.Write("\n4.Id cliente");
            Console.Write("\nIngrese el numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string rpta = "N";
            do
            {
                switch (num)
                {
                    case 1:
                        Console.Write("\nIngrese el nuevo nombre: ");
                        string numTar = Console.ReadLine();
                        using (var db = new conDB_EF())
                        {
                            tbTarjeta tarjeta = db.tbTarjeta.Find(idTarjeta);
                            tarjeta.numeroTarjeta = numTar;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idTarjeta + " se editó correctamente.");
                        }
                        break;
                    case 2:
                        Console.Write("\nIngrese el tipo de tarjeta: ");
                        string tipTar = Console.ReadLine();
                        using (var db = new conDB_EF())
                        {
                            tbTarjeta tarjeta = db.tbTarjeta.Find(idTarjeta);
                            tarjeta.tipoTarjeta = tipTar;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idTarjeta + " se editó correctamente.");
                        }
                        break;
                    case 3:
                        Console.Write("\nIngrese el modo pago: ");
                        string modTar = Console.ReadLine();
                        using (var db = new conDB_EF())
                        {
                            tbTarjeta tarjeta = db.tbTarjeta.Find(idTarjeta);
                            tarjeta.modoPago = modTar;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idTarjeta + " se editó correctamente.");
                        }
                        break;
                    case 4:
                        Console.Write("\nIngrese la fecha: ");
                        string fecTar = Console.ReadLine();
                        using (var db = new conDB_EF())
                        {
                            tbTarjeta tarjeta = db.tbTarjeta.Find(idTarjeta);
                            tarjeta.fechaVencimiento = fecTar;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idTarjeta + " se editó correctamente.");
                        }
                        break;
                    case 5:
                        Console.Write("\nIngrese el cliente: ");
                        int idc = Convert.ToInt32(Console.ReadLine());
                        using (var db = new conDB_EF())
                        {
                            tbTarjeta tarjeta = db.tbTarjeta.Find(idTarjeta);
                            tarjeta.idCliente = idc;
                            db.SaveChanges();
                            Console.WriteLine("El registro con código " + idTarjeta + " se editó correctamente.");
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
