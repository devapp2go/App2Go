using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTemplate.Data
{
    [Table("tbl_vehiculo")]
    public class Vehiculo
    {
        public Vehiculo()
        {
            Polizas = new HashSet<Poliza>();
        }

        [Key]
        public int IdVehiculo { get; set; }

        [StringLength(120)]
        public string Placas { get; set; }
        public ColorVehiculo Color { get; set; }

        
        public Marca Marca { get; set; }

        public ICollection<Poliza> Polizas { get; set; }

        public enum ColorVehiculo
        {
            Azul = 1,
            Verde = 2,
            Rojo = 3,
            Amarillo = 4,
            Morado = 5,
            Cafe = 6
        }
    }
}
