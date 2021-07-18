using Practicap2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                Console.WriteLine(item.idTarjeta);
            }
        }
        public void RegistraTarjeta()
        {
            Console.Clear();
            Console.WriteLine("Registrar Tarjeta");
            Console.Write("\nIngrese numero Tarjeta: ");
            string numeroTarjeta = Console.ReadLine();
            tbTarjeta Tarjeta = new tbTarjeta { numeroTarjeta = numeroTarjeta };
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
            int idTarjeta= Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el nuevo numero: ");
            string nombreTar = Console.ReadLine();
            using (var db = new conDB_EF())
            {
                tbPais pais = db.tbPais.Find(idTarjeta);
                pais.nombrePais = nombreTar;
                db.SaveChanges();
                Console.WriteLine("El registro con código " + idTarjeta + " se editó correctamente.");
            }
        }
    }
}
