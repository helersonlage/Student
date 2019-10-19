using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student std1 = new Student();
            std1.name = "Vanessa";
            std1.age = 29;

            Student std2 = new Student();
            std2.name = "Alice";
            std2.age = 1;

            Student std3 = new Student();
            std3.name = "Sophie";
            std3.age = 10;

            Student std4 = new Student();
            std4.name = "Kass";
            std4.age = 21;


            var students = new List<Student>();
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);
            students.Add(std4);


            var returnOrderByname = new studentService().OrderByName(students);


            foreach (var item in returnOrderByname)
            {
                Console.WriteLine($"name: {item.name} AGE: {item.age}");
            }


            // Console.WriteLine("Hello World!");
        }
    }


    public class Student
    {
        public string name;
        public int age;
    }

    public class studentService
    {

        public List<Student> OrderByName(List<Student> std)
        {
            return std.OrderBy(a => a.name).ToList();
        }

        public List<Student> OrderByAge(List<Student> std)
        {
            return std.OrderBy(a => a.age).ToList();
        }

    }


}


