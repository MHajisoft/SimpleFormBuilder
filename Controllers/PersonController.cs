using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using SimpleFormBuilder.Models;

namespace SimpleFormBuilder.Controllers
{
    public class PersonController : BaseController
    {
        public ActionResult Index()
        {
            var model = new PersonListModel
            {
                Persons = Context.Persons.AsNoTracking().ToList()
            };

            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = new PersonDetailModel
            {
                Person = Context.Persons.SingleOrDefault(x => x.Id == id)
            };

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var entity = Context.Persons.Single(x => x.Id == id);
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();

            return Redirect(Url.Action("Index", "Person"));
        }
    }
}