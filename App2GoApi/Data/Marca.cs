using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTemplate.Data
{
    [Table("tbl_marca")]
    public class Marca
    {
        public Marca()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        [Key]
        public int IdMarca { get; set; }
        public string Nombre { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
