using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleFormBuilder.Attributes;

namespace SimpleFormBuilder.Entity
{
    public class Person : BaseEntity
    {
        //ToDo افزودن اتریبیوت های نمایش عنوان و توضیحات فیلد در صفحه طراحی

        [ShowInDesigner]
        public string FirstName { get; set; }

        [ShowInDesigner]
        public string LastName { get; set; }

        [ShowInDesigner]
        public int ChildCount { get; set; }

        [ShowInDesigner]
        public DateTime? BirthDate { get; set; }

        [ShowInDesigner]
        public byte[] Picture { get; set; }
        public HttpPostedFileBase PictureString { get; set; }

        public string TagsList { get; set; }

        [ShowInDesigner]
        public List<string> Tags
        {
            get => TagsList?.Split(',').ToList();
            set => TagsList = value != null ? string.Join(",", value) : null;
        }
    }
}