using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using SimpleFormBuilder.Attributes;
using SimpleFormBuilder.Entity;
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

        public ActionResult Add()
        {
            return View("Detail", GetPersonDetailModel(new Person()));
        }

        public ActionResult Detail(int id)
        {
            return View(GetPersonDetailModel(Context.Persons.Single(x => x.Id == id)));
        }

        [HttpPost]
        public ActionResult Update(PersonDetailModel model)
        {
            if (model.Person.PictureString != null)
            {
                var target = new MemoryStream();
                model.Person.PictureString.InputStream.CopyTo(target);
                model.Person.Picture = target.ToArray();
            }

            if (model.Person.Id > 0)
            {
                var entity = Context.Persons.Single(x => x.Id == model.Person.Id);

                //ToDo Use AutoMapper
                 entity.FirstName = model.Person.FirstName;
                entity.LastName = model.Person.LastName;
                entity.ChildCount = model.Person.ChildCount;
                entity.BirthDate = model.Person.BirthDate;
                if (model.Person.PictureString != null)
                    entity.Picture = model.Person.Picture;
                entity.Tags = model.Person.Tags;

                Context.Entry(entity).State = EntityState.Modified;
            }
            else
                Context.Persons.Add(model.Person);

            Context.SaveChanges();

            return Redirect(Url.Action("Index", "Person"));
        }

        public ActionResult Delete(int id)
        {
            var entity = Context.Persons.Single(x => x.Id == id);
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();

            return Redirect(Url.Action("Index", "Person"));
        }

        private PersonDetailModel GetPersonDetailModel(Person person)
        {
            var model = new PersonDetailModel
            {
                Person = person,
                PersonProperties = typeof(Person).GetProperties().Where(x => Attribute.IsDefined(x, typeof(ShowInDesignerAttribute))).ToList(),
                CustomProperties = Context.CustomProperties.AsNoTracking().Where(x => x.EntityName == nameof(Person) && x.IsActive).OrderBy(x => x.OrderIndex).ToList()
            };

            return model;
        }
    }
}