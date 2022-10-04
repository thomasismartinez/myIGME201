using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLib
{
    public class Course
    {
        public string courseCode;
        public string description;
        public string teacherEmail;
        public Schedule schedule;

        public Course() { }

        public Course(string courseCode, string description)
        {
            this.courseCode = courseCode;
            this.description = description;
        }
    }
}
