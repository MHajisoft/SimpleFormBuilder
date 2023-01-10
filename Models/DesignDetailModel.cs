using System.Collections.Generic;
using System.Web.WebPages.Html;
using SimpleFormBuilder.Entity;
using SelectListItem = System.Web.Mvc.SelectListItem;

namespace SimpleFormBuilder.Models
{
    public class DesignDetailModel
    {
        public CustomProperty CustomProperty { get; set; }
        
        public List<SelectListItem> PropertyNames { get; set; }
    }
}