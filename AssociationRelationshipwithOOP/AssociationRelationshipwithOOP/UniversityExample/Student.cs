using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipwithOOP.UniversityExample
{
    public class Student
    {
        public Student()
        {
            Department  =new Department();
        }

        public Student(string name, string regNo, string email, string phone)
        {
            Name = name;
            RegNo = regNo;
            Email = email;
            Phone = phone;
        }

        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Department Department { get; set; }

        public string GetStudentInfo()
        {
            string message = "";
            message += $"{Name}\t\t{RegNo}\t\t{Email}\t\t{Phone}\n";
            return message;
        }
    }
}
