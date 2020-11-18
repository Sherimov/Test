using System;
using System.Collections.Generic;
using System.Text;

namespace PolarCape.CollegeApp.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public Semester Semester { get; set; }
    }

    public enum Semester
    {
        First,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Eighth
    }
}
