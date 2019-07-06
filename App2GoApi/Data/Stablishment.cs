using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class Stablishment : BaseEntity
    {
        public Stablishment()
        {
            ProductStocks = new HashSet<ProductStock>();
            Purchases = new HashSet<Purchase>();
        }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        public int AppDataId { get; set; }
        public AppData AppData { get; set; }

        public virtual ICollection<ProductStock> ProductStocks { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
