using System;
using System.Collections.Generic;

namespace SimpleFormBuilder.Entity
{
    public class Person : BaseEntity
    {
        //ToDo افزودن اتریبیوت های نمایش عنوان و توضیحات فیلد در صفحه طراحی
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime? BirthDate { get; set; }

        public byte[] Picture { get; set; }

        public List<string> Tags { get; set; }
    }
}