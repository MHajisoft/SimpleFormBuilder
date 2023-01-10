using System.Collections.Generic;
using SimpleFormBuilder.Entity;

namespace SimpleFormBuilder.Models
{
    public class DesignListModel
    {
        public string EntityName { get; set; }
        
        public List<CustomProperty> Properties { get; set; }
    }
}