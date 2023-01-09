using System.Web.Mvc;
using SimpleFormBuilder.Database;

namespace SimpleFormBuilder.Controllers
{
    public class BaseController : Controller
    {
        protected AppDbContext Context { get; set; }

        public BaseController()
        {
            Context = new AppDbContext();
        }
    }
}