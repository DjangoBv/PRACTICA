using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    [Table("tbPais")]
    public class Pais
    {
        [Key]
        public int idPais { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string nombrePais { get; set; }

        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string codigoPais { get; set; }

        public List<Viaje> Viaje { get; set; }
    }
}
