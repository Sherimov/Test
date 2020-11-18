using System;
using System.Collections.Generic;
using System.Text;

namespace PolarCape.CollegeApp.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        public IEnumerable<SubjectModel> Subjects { get; set; }
    }
}
