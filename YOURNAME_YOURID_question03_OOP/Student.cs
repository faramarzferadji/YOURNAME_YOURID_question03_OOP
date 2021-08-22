using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOURNAME_YOURID_question03_OOP
{
    public class Student
    {
        public Student()//This is a defalt constructor
        {

        }
        public Student(int studentId)
        {
            StudentId = studentId;
        }
        public int StudentId { get; private set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentHomeAddress { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(StudentName)) isValid = false;
            if (string.IsNullOrWhiteSpace(StudentEmail)) isValid = false;
            return isValid;
        }
    }
}
