using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class AppWidgetParam : BaseEntity
    {
        public AppWidgetParam()
        {

        }

        public string Value { get; set; }

        public int AppWidgetId { get; set; }
        public AppWidget AppWidget { get; set; }

        public int WidgetParamId { get; set; }
        public WidgetParam WidgetParam { get; set; }
    }
}
