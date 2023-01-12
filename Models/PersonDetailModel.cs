using System.Collections.Generic;
using System.Reflection;
using SimpleFormBuilder.Entity;

namespace SimpleFormBuilder.Models
{
    public class PersonDetailModel
    {
        public Person Person { get; set; }

        public List<CustomProperty> CustomProperties { get; set; }

        public List<PropertyInfo> PersonProperties { get; set; }
    }
}