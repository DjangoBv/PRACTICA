using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string nombreCliente { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string apellidoCliente { get; set; }

        [Required]
        public DateTime fechaNacimiento { get; set; }

        [StringLength(15)]
        [Column(TypeName = "varchar")]
        public string dniCliente { get; set; }
        public List<Tarjeta> Tarjeta { get; set; }
    }
}
