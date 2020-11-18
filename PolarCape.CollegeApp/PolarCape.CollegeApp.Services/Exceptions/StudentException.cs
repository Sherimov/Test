using System;
using System.Collections.Generic;
using System.Text;

namespace PolarCape.CollegeApp.Services.Exceptions
{
    public class StudentException : Exception
    {
        public int? StudentId { get; set; }
        public string FullName { get; set; }

        public StudentException(int? studentId, string fullName)
            : base("There has beed an isssue with a user")
        {
            StudentId = studentId;
            FullName = fullName;
        }

        public StudentException(int? studentId, string fullName, string message)
            : base(message)
        {
            StudentId = studentId;
            FullName = fullName;
        }
    }
}
