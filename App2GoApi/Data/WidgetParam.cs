using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class WidgetParam : BaseEntity
    {
        public WidgetParam()
        {
            AppWidgetParams = new HashSet<AppWidgetParam>();
        }

        public bool IsRequired { get; set; }

        public int FieldTypeId { get; set; }
        public FieldType FieldType { get; set; }

        public int WidgetId { get; set; }
        public Widget Widget { get; set; }

        public virtual ICollection<AppWidgetParam> AppWidgetParams { get; set; }
    }
}
