using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YOURNAME_YOURID_question03_OOP;

namespace YOURNAME_YOURID_question03_OOP.Test
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentName()
        {
            Student student = new Student();
            student.StudentName = "Faramarz";
            string expected = "Faramarz";
            string actuel = student.StudentName;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]

        public void StudentEmail()
        {
            Student student = new Student();
            student.StudentEmail = "Faramarz@.ca";
            string expected = "Faramarz@.ca";
            string actuel = student.StudentEmail;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]

        public void StudentHomeAddress()
        {
            Student student = new Student();
            student.StudentHomeAddress = "8925 omega";
            string expected = "8925 omega";
            string actuel = student.StudentHomeAddress;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void ValidValidation()
        {
            Student student = new Student
            {
                StudentName = "Faramarz",
                StudentEmail = "Faramarz@.ca"
            };
            var expected = true;
            var actuel = student.Validate();
            Assert.AreEqual(expected, actuel);

        }


    }
}
