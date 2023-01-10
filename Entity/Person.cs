using System;
using System.Collections.Generic;
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
        public int Age { get; set; }

        [ShowInDesigner]
        public DateTime? BirthDate { get; set; }

        [ShowInDesigner]
        public byte[] Picture { get; set; }

        [ShowInDesigner]
        public List<string> Tags { get; set; }
    }
}