using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    class student
    {
        int sid;
        string sname;
        string college;

        public student()
        {
            sid = 8;
            sname = "Ashok";
            college = "DIET";
        }

        public student(int Sid,string Sname)
        {
            sid = Sid;
            sname = Sname;
            college = "Not Provided";
        }

        public student(string sname, string college)
        {
            sid = 0;
            this.sname=sname;
            this.college=college;
        }

        //public student(int Sid, string college)
        //{
        //    sid = Sid;
        //    this.college = college;
        //}

        public student(int sid,string Sname, string college)
        {
            this.sid = sid;
            sname = Sname;
            this.college = college;
        }

        public void displaystudentdetails()
        {
            Console.WriteLine("Student ID is:" +" "+ sid);
            Console.WriteLine("Student Name is:" +" "+ sname);
            Console.WriteLine("student College is:" +" "+college);
            Console.WriteLine("------------------------------------");
        }
    }

    internal class Student_eg2
    {
        static void Main(string[] args)
        {
            student con1 = new student();
            con1.displaystudentdetails();

            student con2 = new student();
            con2.displaystudentdetails();

            student con3 = new student(18,"Kiran");
            con3.displaystudentdetails();

            student con4 = new student("Ravi", "DVN");
            con4.displaystudentdetails();

        }
    }
}
