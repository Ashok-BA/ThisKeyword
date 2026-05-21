using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    class student
    {
        int id;
        string sname;

        public student(int id, string sname)
        {
            this.id = id;
            this.sname = sname;
        }

        public void displaydetails()
        {
            Console.WriteLine("student Id is:" + id);
            Console.WriteLine("Student Name is:" + sname);
        }
    }

    internal class Student
    {
        static void Main(string[] args)
        {
            student std = new student(8, "ashok");
            std.displaydetails();
        }
    }
}
