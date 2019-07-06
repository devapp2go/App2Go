using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Created = DateTime.Now.ToUniversalTime();
            Updated = DateTime.Now.ToUniversalTime();
        }

        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [Column(Order = 30)]
        public DateTime Created { get; set; }
        [Required]
        [Column(Order = 31)]
        public DateTime Updated { get; set; }
        [Column(Order = 32)]
        public DateTime Deleted { get; set; }
        [Column(Order = 33)]
        public bool Active { get; set; }
    }
}
