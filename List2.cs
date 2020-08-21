using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Student{

        private string name;
        private string dep;
        private double cgpa;

        public Student(string aName,string aDep,double aCgpa) {
            this.name = aName;
            this.dep = aDep;
            this.cgpa = aCgpa;
        }

        // These methods are called objects method.
        public bool hasHonors() {
            if (this.cgpa >= 3.5) {
                return true;
            }
            return false;
        }

        public void showInformation() {

            Console.WriteLine(this.name);
            Console.WriteLine(this.dep);
            Console.WriteLine(this.cgpa);
        }

    }
}
