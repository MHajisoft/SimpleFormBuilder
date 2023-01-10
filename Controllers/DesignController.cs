using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web.Mvc;
using SimpleFormBuilder.Attributes;
using SimpleFormBuilder.Entity;
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

        public ActionResult Add(string entity)
        {
            return View("Detail", GetDesignDetailModel(new CustomProperty { EntityName = entity }));
        }

        public ActionResult Detail(int id)
        {
            return View(GetDesignDetailModel(Context.CustomProperties.Single(x => x.Id == id)));
        }

        [HttpPost]
        public ActionResult Update(DesignDetailModel model)
        {
            if (model.CustomProperty.Id > 0)
            {
                var entity = Context.CustomProperties.Single(x => x.Id == model.CustomProperty.Id);

                //ToDo Use AutoMapper
                entity.EntityName = model.CustomProperty.EntityName;
                entity.PropertyName = model.CustomProperty.PropertyName;
                entity.Title = model.CustomProperty.Title;
                entity.OrderIndex = model.CustomProperty.OrderIndex;
                entity.IsActive = model.CustomProperty.IsActive;

                Context.Entry(entity).State = EntityState.Modified;
            }
            else
                Context.CustomProperties.Add(model.CustomProperty);

            Context.SaveChanges();

            return Redirect(Url.Action("Index", "Design", new { entity = nameof(Person) }));
        }

        public ActionResult Delete(int id)
        {
            var entity = Context.CustomProperties.Single(x => x.Id == id);
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();

            return Redirect(Url.Action("Index", "Design", new { entity = nameof(Person) }));
        }

        private DesignDetailModel GetDesignDetailModel(CustomProperty customProperty)
        {
            var model = new DesignDetailModel
            {
                CustomProperty = customProperty
            };

            var list = typeof(Person).GetProperties()
                .Where(x => Attribute.IsDefined(x, typeof(ShowInDesignerAttribute)))
                .Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToList();
            list.Insert(0, new SelectListItem { Text = "---", Value = string.Empty });

            model.PropertyNames = list;

            return model;
        }
    }
}