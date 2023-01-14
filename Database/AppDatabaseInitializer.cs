using System;
using System.Collections.Generic;
using System.Data.Entity;
using SimpleFormBuilder.Entity;
using SimpleFormBuilder.Migrations;
using SimpleFormBuilder.Resource;
using SimpleFormBuilder.Util;

namespace SimpleFormBuilder.Database
{
    public class AppDatabaseInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.CustomProperties.AddRange(new List<CustomProperty>
            {
                new CustomProperty { EntityName = nameof(Person), PropertyName = nameof(Person.FirstName), Title = "C-First", OrderIndex = 1, IsActive = true },
                new CustomProperty { EntityName = nameof(Person), PropertyName = nameof(Person.LastName), Title = "C-Last", OrderIndex = 1, IsActive = false },
                new CustomProperty { EntityName = nameof(Person), PropertyName = nameof(Person.ChildCount), Title = "C-Count", OrderIndex = 1, IsActive = false },
                new CustomProperty { EntityName = nameof(Person), PropertyName = nameof(Person.BirthDate), Title = "C-Birth", OrderIndex = 1, IsActive = true },
                new CustomProperty { EntityName = nameof(Person), PropertyName = nameof(Person.Picture), Title = "C-Pic", OrderIndex = 1, IsActive = true },
                new CustomProperty { EntityName = nameof(Person), PropertyName = nameof(Person.Tags), Title = "C-Tag", OrderIndex = 1, IsActive = true }
            });

            context.Persons.AddRange(new List<Person>
            {
                new Person { FirstName = "Ali", LastName = "Rezaee", ChildCount = 1, BirthDate = new DateTime(2023, 1, 12), Tags = new List<string> { "Item-04" }, Picture = MvcUtil.ImageToByteArray(AppResource.Ali) },
                new Person { FirstName = "Sara", LastName = "Asadi", ChildCount = 2, BirthDate = new DateTime(2023, 1, 25), Tags = new List<string> { "Item-02", "Item-04" }, Picture = MvcUtil.ImageToByteArray(AppResource.Sara) },
            });

            base.Seed(context);
        }
    }
}