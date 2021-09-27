using System;
using BestraneDemo.Models;
using System.Collections.Generic;
using BestraneDemo.Funtions;

namespace BestraneDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new() { Id = 1, FirstName = "John" };
            Student student2 = new() { Id = 2, FirstName = "Jon" };
            Student student3 = new() { Id = 3, FirstName = "Alex" };
            Student student4 = new() { Id = 4, FirstName = "Sam" };


            List<Student> studentList1 = new() { student1, student2, student3 };
            List<Student> studentList2 = new() { student4, student3, student1 };


            UniqueName uniqueName = new();
            var result = uniqueName.UniqueNameMethod(studentList1, studentList2);

            foreach(var name in result)
            {
                Console.WriteLine(name);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
