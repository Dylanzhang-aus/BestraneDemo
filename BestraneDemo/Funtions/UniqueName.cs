using System;
using System.Collections.Generic;
using BestraneDemo.Models;

namespace BestraneDemo.Funtions
{
    public class UniqueName
    {
        public List<string> UniqueNameMethod(List<Student> studentList1, List<Student> studentList2)
        {
           
            List<string> uniqueNameList = new();


            //add all the student name in the student list 1
            for(int i=0; i<studentList1.Count; i++)
            {
                //fixed bug
                if (!uniqueNameList.Contains(studentList1[i].FirstName))
                {
                    uniqueNameList.Add(studentList1[i].FirstName);
                }
            }

            foreach(var student in studentList2)
            {
                if (!uniqueNameList.Contains(student.FirstName))
                {
                    uniqueNameList.Add(student.FirstName);
                }
            }

            return uniqueNameList;
        }
    }
}
