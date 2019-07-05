using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTemplate.Data
{
    [Table("tbl_polizas")]
    public class Poliza
    {

        [Key]
        public int IdPoliza { get; set; }
        public int IdVehiculo { get; set; }
        public string Codigo { get; set; }
        public int Tipo { get; set; }
        public decimal Costo { get; set; }

        public Vehiculo Vehiculo { get; set; }
    }
}
