using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class AppData : BaseEntity
    {
        public AppData()
        {
            Apps = new HashSet<App>();
            Products = new HashSet<Product>();
            Stablishments = new HashSet<Stablishment>();

        }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [StringLength(300)]
        [Required]
        public string Logo { get; set; }

        [Required]
        public virtual ICollection<App> Apps { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Stablishment> Stablishments { get; set; }

    }
}
