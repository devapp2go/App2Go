using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class AppPlan : BaseEntity
    {
        public AppPlan()
        {
            ClientPlans = new HashSet<ClientPlan>();
        }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        [StringLength(200)]
        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Cost { get; set; }
        public virtual ICollection<ClientPlan> ClientPlans { get; set; }

    }
}
