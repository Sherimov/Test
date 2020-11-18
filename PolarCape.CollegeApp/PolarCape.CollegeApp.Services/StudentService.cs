using PolarCape.CollegeApp.DataAccess;
using PolarCape.CollegeApp.DataModel;
using PolarCape.CollegeApp.Models;
using PolarCape.CollegeApp.Services.Exceptions;
using PolarCape.CollegeApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PolarCape.CollegeApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;


        public bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.CultureInvariant | RegexOptions.Singleline);


            bool isValidEmail = regex.IsMatch(email);
            if (!isValidEmail)
            {
                return false;
            }

            return true;
        }

        public long ValidatePhone(long phone)
        {
            Regex regex = new Regex(@"((00)?\+?[389]{3})?[\/\-\s*\.]?(((\(0\))|0)?\s*7\d{1})[\/\-\s*\.\,]?([\d]{3})[\/\-\s*\.\,]?([\d]{3})",
                 RegexOptions.CultureInvariant | RegexOptions.Singleline);

            bool isValidNumber = regex.IsMatch(phone);
        }

        public bool HasTwoOrMoreSubjects (IEnumerable<Subject> listOfSubjects)
        {
            if(listOfSubjects.Count => 1)
        }

        public void Register(StudentModel request)
        {
            
            if (string.IsNullOrWhiteSpace(request.FullName))
            {
                throw new StudentException(null, request.FullName,
                    "Fullname is required"); // should use custom exception
            }

            if (!ValidateEmail(request.Email))
            {
                throw new StudentException(null, request.Email,
                    "Email is required in acceptable format");
            }


            var student = new Student
            {
                FullName = request.FullName,
                Email = request.Email,
                Phone = request.Phone,
                
            };

            _studentRepository.Insert(student);
        }
    }
}
