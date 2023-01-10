using System.Web.Mvc;
using SimpleFormBuilder.Entity;

namespace SimpleFormBuilder.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return Redirect(Url.Action("Index", "Design", new { entity = nameof(Person) }));
        }
    }
}