using Practicap2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicap2.CRUD_Pais
{
    public class PaisDAO
    {
        public void ListaPais()
        {
            Console.Clear();
            List<tbPais> listaPais = new List<tbPais>();
            using (var db = new conDB_EF())
            {
                listaPais = db.tbPais.ToList();
            }
            Console.WriteLine("Lista de pais");
            foreach (var item in listaPais)
            {
                Console.WriteLine(item.idPais);
            }
        }
        public void RegistraPais()
        {
            Console.Clear();
            Console.WriteLine("Registrar Pais");
            Console.Write("\nIngrese nombre Pais: ");
            string nombrePais = Console.ReadLine();
            tbPais Pais = new tbPais { nombrePais = nombrePais };
            using (var db = new conDB_EF())
            {
                db.tbPais.Add(Pais);
                db.SaveChanges();
            }
            Console.WriteLine("Se registró correctamente");
        }

        public void EditarPais()
        {
            Console.Clear();
            ListaPais();
            Console.Write("\nIngrese el ID del cliente a editar: ");
            int idPais= Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el nuevo nombre: ");
            string nombrePais = Console.ReadLine();
            using (var db = new conDB_EF())
            {
                tbPais pais = db.tbPais.Find(idPais);
                pais.nombrePais = nombrePais;
                db.SaveChanges();
                Console.WriteLine("El registro con código " + idPais + " se editó correctamente.");
            }
        }
    }
}
