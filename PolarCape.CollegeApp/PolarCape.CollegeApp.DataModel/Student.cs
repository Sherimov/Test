using System;
using System.Collections.Generic;
using System.Text;

namespace PolarCape.CollegeApp.DataModel
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        public IEnumerable<Subject> Subjects { get; set; }
    }
}
