using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class CustomUserField : BaseEntity
    {
        public CustomUserField()
        {

        }

        public string Name { get; set; }
        public bool Required { get; set; }

        public int AppId { get; set; }
        public App App { get; set; }

        public int FieldTypeId { get; set; }
        public FieldType FieldType { get; set; }

    }
}
