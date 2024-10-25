using System;
using System.Collections.Generic;
using static Assignment7.University.Department;

namespace Assignment7
{
    public class University
    {
        private List<Department> DeptList = new List<Department>();

        public void AddDept(Department dept)
        {
            DeptList.Add(dept);
        }

        public void Display()
        {
            foreach (var dep in DeptList)
            {
                Console.WriteLine($"Department Name: {dep.Name}");
                dep.DisplayCourses();
            }
        }

        public class Department
        {
            private List<Course> CourseList = new List<Course>();
            public string Name { get; set; }

            public Department(string name)
            {
                Name = name;
            }

            public void AddCourse(Course course)
            {
                CourseList.Add(course);
            }

            public void DisplayCourses()
            {
                foreach (var course in CourseList)
                {
                    Console.WriteLine($"Course Code: {course.CCode} --- Course Name: {course.CName} --- Credits: {course.Credits}");
                }
            }

            public class Course
            {
                public string CName { get; set; }
                public string CCode { get; set; }
                public string Credits { get; set; }

                public Course(string cname, string ccode, string credits)
                {
                    CName = cname;
                    CCode = ccode;
                    Credits = credits;
                }
            }
        }

        static void Main(string[] args)
        {
            University university = new University();
            Console.Write("Enter the number of departments: ");
            int numDepts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numDepts; i++)
            {
                Console.Write("Enter department name: ");
                string deptName = Console.ReadLine();
                Department department = new Department(deptName);

                Console.Write("Enter the number of courses in this department: ");
                int numCourses = int.Parse(Console.ReadLine());

                for (int j = 0; j < numCourses; j++)
                {
                    Console.Write("Enter course name: ");
                    string courseName = Console.ReadLine();

                    Console.Write("Enter course code: ");
                    string courseCode = Console.ReadLine();

                    Console.Write("Enter credits: ");
                    string credits = Console.ReadLine();

                    Course course = new Course(courseName, courseCode, credits);
                    department.AddCourse(course);
                }

                university.AddDept(department);
                Console.WriteLine("\n");
            }

            Console.WriteLine("-----------------------------");
            university.Display();
            Console.ReadLine();
        }
    }
}
