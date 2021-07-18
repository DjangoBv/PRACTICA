using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbTarjeta")]
    public class Tarjeta
    {
        [Key]
        public int idTarjeta { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string nombreTarjeta { get; set; }

        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string tipoTarjeta { get; set; }

        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string modoPago { get; set; }

        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string fechaVencimiento { get; set; }

        [Required]
        public int idCliente { get; set; }

        public List<Viaje> Viaje { get; set; }
        public Cliente Cliente { get; set; }
    }
}
