using System.Linq;
using System.Web.Mvc;
using SimpleFormBuilder.Models;

namespace SimpleFormBuilder.Controllers
{
    public class DesignController : BaseController
    {
        public ActionResult Index(string entity)
        {
            var model = new DesignListModel
            {
                EntityName = entity,
                Properties = Context.CustomProperties.AsNoTracking().Where(x => x.EntityName.Equals(entity)).ToList()
            };

            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = new DesignDetailModel
            {
                CustomProperty = Context.CustomProperties.SingleOrDefault(x => x.Id == id)
            };

            return View(model);
        }
    }
}