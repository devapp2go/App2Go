using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class ClientUser : BaseEntity
    {
        public ClientUser()
        {
            Clients = new HashSet<Client>();
        }

        [StringLength(100)]
        [Required]
        public string Username { get; set; }

        [StringLength(200)]
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
