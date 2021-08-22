using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YOURNAME_YOURID_question03_OOP;

namespace YOURNAME_YOURID_question03_OOP.Test
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseTitle()
        {
            Course course = new Course();
            course.CourseTitle = "Math";
            string expected = "Math";
            string actuel = "Math";
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void CourseDescription()
        {
            Course course = new Course();
            course.CourseDiscription = "Math1 and History request";
            string expected = "Math1 and History request";
            string actuel = course.CourseDiscription;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void ValidValidation()
        {
            Course course = new Course()
            {
                CourseTitle = "Math",
                CourseDiscription = "Math1 and History request"
            };
            var expected = true;
            var actuel = course.ValidCourse();
            Assert.AreEqual(expected, actuel);


        }

    }

}
