using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("connBD")
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Tarjeta> Tarjeta { get; set; }
        public DbSet<Viaje> Viaje { get; set; }

    }
}
