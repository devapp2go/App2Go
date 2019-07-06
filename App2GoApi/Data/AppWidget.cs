using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class AppWidget : BaseEntity
    {
        public AppWidget()
        {
            AppWidgetParams = new HashSet<AppWidgetParam>();
        }

        public int WidgetId { get; set; }
        public Widget Widget { get; set; }

        public int AppId { get; set; }
        public App App { get; set; }

        public virtual ICollection<AppWidgetParam> AppWidgetParams { get; set; }

    }
}
