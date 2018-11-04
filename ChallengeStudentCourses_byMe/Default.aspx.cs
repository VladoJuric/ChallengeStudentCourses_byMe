using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses_byMe
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            string result = "";

            List<Course> courses = new List<Course>() {
                new Course() {CourseId = 1, Name = "Econ 101", Students = new List<Student>()
                {
                    new Student() { StudentId = 1, Name = "Bob Tabor"},
                    new Student() { StudentId = 2, Name = "Steve Jaworski"}
                }},
                new Course() {CourseId = 2, Name = "Discrete Math", Students = new List<Student>()
                {
                    new Student() { StudentId = 3, Name = "Brian Faley"},
                    new Student() { StudentId = 4, Name = "Chuck Ravetto"}
                }},
                new Course() {CourseId = 3, Name = "History 302", Students = new List<Student>()
                {
                    new Student() { StudentId = 5, Name = "Andrew Flowers"},
                    new Student() { StudentId = 6, Name = "Andrew Sekala"}
                }}
            };

            foreach (var course in courses)
            {
                result += "<br/>Course: " + course.CourseId.ToString() + " - " + course.Name;
                foreach (var student in course.Students)
                {
                    result += "<br/>&nbsp;&nbsp;Student: " + student.StudentId.ToString() + " " + student.Name.ToString();
                }
            }

            resultLabel.Text = result;

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            string result = "";

            Course course1 = new Course() { CourseId = 1, Name = "Algebra 3"};
            Course course2 = new Course() { CourseId = 2, Name = "Psychology" };
            Course course3 = new Course() { CourseId = 3, Name = "Business Law" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student() { StudentId = 1, Name = "Bob Tabor", Courses = new List<Course>() { course1,course2 }}},
                { 2, new Student() { StudentId = 2, Name = "Steve Jaworski", Courses = new List<Course>() { course2,course3}}},
                { 3, new Student() { StudentId = 3, Name = "Chuck Ravetto", Courses = new List<Course>() { course3,course1}}}
            };

            foreach (var student in students)
            {
                result += "<br/>Student: " + student.Value.StudentId.ToString() + " - " + student.Value.Name.ToString();
                foreach (var valueCourse in student.Value.Courses)
                {
                    result += "<br/>&nbsp;&nbsp;Course: " + valueCourse.CourseId + " " + valueCourse.Name;
                }
            }

            resultLabel.Text = result;
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            string result = "";

            Student student = new Student();
            student.StudentId = 1;
            student.Name = "Bob Tabor";
            student.Enrollments = new List<Enrollment>()
            {
                new Enrollment() { Grade = 92, Course = new Course() { CourseId = 1, Name = "Physiology 101"}},
                new Enrollment() { Grade = 96, Course = new Course() { CourseId = 2, Name = "Project Manager 432"}}
            };

            result += "<br/>Student: " + student.StudentId.ToString() + " " + student.Name.ToString();
            foreach (var enrollment in student.Enrollments)
            {
                result += "<br/>&nbsp;&nbsp;Enrolled in: " + enrollment.Course.Name.ToString() + " " + enrollment.Grade;
            }

            resultLabel.Text = result;
        }
    }
}