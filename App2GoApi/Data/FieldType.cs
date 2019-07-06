using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class FieldType : BaseEntity
    {
        public FieldType()
        {
            WidgetParams = new HashSet<WidgetParam>();
        }

        [StringLength(50)]
        [Required]
        public string Type { get; set; }
        [StringLength(50)]
        [Required]
        public string Description { get; set; }

        public virtual ICollection<WidgetParam> WidgetParams { get; set; }
    }
}
