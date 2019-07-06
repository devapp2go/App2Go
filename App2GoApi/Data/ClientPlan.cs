using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class ClientPlan : BaseEntity
    {
        public ClientPlan()
        {

        }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int AppId { get; set; }
        public App App { get; set; }

        public int AppPlanId { get; set; }
        public AppPlan AppPlan { get; set; }
    }
}
