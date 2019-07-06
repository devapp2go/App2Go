using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class Product : BaseEntity
    {
        public Product()
        {
            PurchaseProductsVar = new HashSet<PurchaseProducts>();
        }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Cost { get; set; }

        [StringLength(1000)]
        [Required]
        public string Description { get; set; }

        [Required]
        public virtual ICollection<PurchaseProducts> PurchaseProductsVar { get; set; }

        public int AppDataId { get; set; }
        public AppData AppData { get; set; }

       

    }
}
