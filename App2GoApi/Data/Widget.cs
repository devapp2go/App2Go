using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class Widget : BaseEntity
    {
        public Widget()
        {
            AppWidgets = new HashSet<AppWidget>();
            WidgetParams = new HashSet<WidgetParam>();
        }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(300)]
        [Required]
        public string Description { get; set; }

        public virtual ICollection<AppWidget> AppWidgets { get; set; }
        public virtual ICollection<WidgetParam> WidgetParams { get; set; }
    }
}
