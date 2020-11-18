using PolarCape.CollegeApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolarCape.CollegeApp.Services.Interfaces
{
    public interface IStudentService
    {
        StudentModel ValidateEmail(string email);
        long ValidatePhone(long phone);
        
    }
}
