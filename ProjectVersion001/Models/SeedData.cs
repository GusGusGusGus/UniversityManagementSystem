using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectVersion001.Models
{
    public class SeedData : DropCreateDatabaseIfModelChanges<UniversityDbContex>
    {
        protected override void Seed(UniversityDbContex context)
        {

            //Semesters
            context.Semesters.Add(new Semester() {Semestername = "Fall 2020"});
            context.Semesters.Add(new Semester() { Semestername = "Summer 2020" });
            context.Semesters.Add(new Semester() { Semestername = "Spring 2020" });
            context.Semesters.Add(new Semester() { Semestername = "Fall 2021" });
            context.Semesters.Add(new Semester() { Semestername = "Summer 2021" });
            context.Semesters.Add(new Semester() { Semestername = "Spring 2021" });
            context.Semesters.Add(new Semester() { Semestername = "Fall 2022" });
            context.Semesters.Add(new Semester() { Semestername = "Summer 2022" });



            //Designation
            context.Designations.Add(new Designation(){ DesignationName = "Professor"});
            context.Designations.Add(new Designation() { DesignationName = "asst. Professor" });
            context.Designations.Add(new Designation() { DesignationName = "Lecturer" });
            context.Designations.Add(new Designation() { DesignationName = "Asst Lecturer" });

            //Department
            context.Departments.Add(new Department(){Code = "CSE",Name = "Computer Science"});


            //room
            context.Rooms.Add(new Room(){Name = "A 501"});
            context.Rooms.Add(new Room(){Name = "A 502"});
            context.Rooms.Add(new Room(){Name = "A 505"});
            context.Rooms.Add(new Room(){Name = "B 601"});
            context.Rooms.Add(new Room(){Name = "B 609"});
            context.Rooms.Add(new Room(){Name = "MCL A"});


            //Day

            context.Days.Add(new Day() { Name = "SaturDay" });
            context.Days.Add(new Day() { Name = "SunDay" });
            context.Days.Add(new Day() { Name = "MonDay" });
            context.Days.Add(new Day() { Name = "TuesDay" });
            context.Days.Add(new Day() { Name = "WednesDay" });
            context.Days.Add(new Day() { Name = "ThursDay" });
            context.Days.Add(new Day() { Name = "Friday" });

            //grade
            context.Grades.Add(new Grade() { Name = "A+" });
            context.Grades.Add(new Grade() { Name = "A" });
            context.Grades.Add(new Grade() { Name = "B+" });
            context.Grades.Add(new Grade() { Name = "B" });
            context.Grades.Add(new Grade() { Name = "C+" });
            context.Grades.Add(new Grade() { Name = "C" });
            context.Grades.Add(new Grade() { Name = "D" });
            context.Grades.Add(new Grade() { Name = "F" });

            //context.Departments.Add(new Department() { Code = "XPTO", Name = "Direito" });

            //context.Teachers.Add(new Teacher()
            //{
            //    Name = "Marcelo Rebelo de Sousa",
            //    Address = "123 Belem",
            //    Contact = "+35169696969",
            //    Email = "hugsmaster@gmail.com",
            //    CreditTaken = 69.6D,
            //    DesignationId = 1,
            //    DepartmentId = 1,
            //    TeacherDepartment = new Department() { Code = "XPTA", Name = "Direito A Serio" },
            //}); 

            //context.Courses.Add(
            //    new Course()
            //{
            //    Code = "001",
            //    Name = "Direito",
            //    Credit = 690.00f,
            //    AssignTo = "Marcelao",


            //});




            context.SaveChanges();



        }
    }
}