using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipwithOOP.UniversityExample
{
    public class Department
    {
        public Department()
        {
            Students=new List<Student>();
        }

        public Department(string name, string code):this()
        {
            Name = name;
            Code = code;
        }

        public string Name { get; set; }
        public string Code { get; set; }
        private List<Student> Students { get; set; }


        public bool AddStudent(Student student)
        {
            //string message = "";
            bool isExists = false;
            foreach (var student2 in Students)
            {
                if(student2.RegNo==student.RegNo)
                {
                    isExists = true;
                    break;
                }
            }
            if(isExists==false)
            {
                Students.Add(student);
                //message = "Student added Successfully";
            }
            return isExists;
        }
        public Student GetStudentByRegNo(string RegNo)
        {
           
            Student student = new Student();
            foreach (var student2 in Students)
            {
                if (student2.RegNo == RegNo)
                {
                    student=student2;
                }
            }
            return student;
           
        }
        public string GetStudentList()
        {

            string report = $"Name \t\t\tRegNo \t\t \tEmail\t\t\t\t Phone \n";
            foreach(var student in Students)
            {
                string studentInformation = student.GetStudentInfo();
                report += studentInformation;
            }    
            return report;
        }
    }
}
