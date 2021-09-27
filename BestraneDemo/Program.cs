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

            List<int> AList1 = new() { 1, 3, 6, 4, 1, 2 };
            List<int> AList2 = new() { 1, 2, 3 };
            List<int> AList3 = new() { -1, -3 };

            UniqueName uniqueName = new();
            Question4 question4 = new();

            var result = uniqueName.UniqueNameMethod(studentList1, studentList2);


            //test case for question 1
            foreach(var name in result)
            {
                Console.WriteLine(name);
            }


            //test case for question 4
            Console.WriteLine(question4.Method(AList1));
            Console.WriteLine(question4.Method(AList2));
            Console.WriteLine(question4.Method(AList3));
        }
    }
}
