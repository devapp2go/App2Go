using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class App : BaseEntity
    {
        public App()
        {
            ClientPlans = new HashSet<ClientPlan>();
        }

        [StringLength(300)]
        public string URL { get; set; }


        public int ClientId { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<ClientPlan> ClientPlans { get; set; }
    }
}
