using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbViaje")]
    public class Viaje
    {
        [Key]
        public int idViaje { get; set; }

        [Required]
        public DateTime fechaInicioViaje { get; set; }

        [Required]
        public DateTime fechaFinViaje { get; set; }

        [StringLength(1)]
        [Column(TypeName = "varchar")]
        public string estadoViaje { get; set; }

        [Required]
        public int idTarjeta { get; set; }

        [Required]
        public Pais Pais { get; set; }
        public Tarjeta Tarjeta { get; set; }
    }
}
