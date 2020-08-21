using Program;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Student student1 = new Student("Onur","Ceng",2.85);
            Student student2 = new Student("Ahmet", "Ee", 3.12);

            List<Student> lst = new List<Student>();
            lst.Add(student1);
            lst.Add(student2);
            viewAllStudentInformation(lst);
        }

        static void viewAllStudentInformation(List<Student> lst)
        {
            Console.WriteLine(lst.Count); // prints the lst size
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].showInformation();

            }


        }
    }
}
