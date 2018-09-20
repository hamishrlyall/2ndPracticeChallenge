using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2ndPracChallenge.Models;

namespace _2ndPracChallenge.ViewModels
{
    public class CourseIndexData
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}