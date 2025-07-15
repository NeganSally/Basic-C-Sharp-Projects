using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_School.admin;

namespace XYZ_School.admin
{

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };
                var stud2 = new Student() { StudentName = "Bob" };
                
                stud.DateOfBirth = DateTime.Now;
                stud.Weight = 120;
                stud.Height = 190;
                
                stud2.DateOfBirth = DateTime.Now;
                stud2.Weight = 200;
                stud2.Height = 170;


                for (int i = 9; i <= 11; i++)
                {
                    var studentToRemove = ctx.Students.Find(i);
                    if (studentToRemove != null)
                    {
                        ctx.Students.Remove(studentToRemove);
                        Console.WriteLine($"Student with ID {i} removed.");
                    }
                    else
                    {
                        Console.WriteLine($"Student with ID {i} not found.");
                    }
                }


                ctx.Students.Add(stud);
                ctx.Students.Add(stud2);
                ctx.SaveChanges();

                Console.Write("Student saved successfully!");

                // The following displays Student table data - dotnetfiddle.net specific code
                //FiddleHelper.WriteTable("Student", ctx.Students.ToList());

                foreach (var item in ctx.Students.ToList())
                {
                    Console.WriteLine("Student Name: " + item.StudentName); 
                    Console.WriteLine("Student ID: " + item.StudentID); 
                    Console.WriteLine("Student DOB" + item.DateOfBirth); 
                    Console.WriteLine("Student Weight: " + item.Weight); 
                    Console.WriteLine("Student Height: " + item.Height); 

                }
            }
        }
    }

}
