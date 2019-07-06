using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class Client : BaseEntity
    {
        public Client()
        {
            ClientPlans = new HashSet<ClientPlan>();
        }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(100)]
        [Required]
        public string LastName { get; set; }

        [StringLength(120)]
        [Required]
        public string Email { get; set; }


        public int ClientUserId { get; set; }
        public ClientUser ClientUser { get; set; }


        public virtual ICollection<ClientPlan> ClientPlans { get; set; }
    }
}

