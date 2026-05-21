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

        public void studentdetails()
        {
            sid = 8;
            sname = "ashok";
        }
        public student(int Sid, string Sname)
        {
            sid = Sid;
            sname = Sname;
        }

        public student(int sid)
        {
            this.sid = sid;
            sname = "Not provided";
        }

        public student(string sname)
        {
            
            this.sname = sname;

        }



        public void Displaydetails()
        {
            Console.WriteLine("Student ID is:" + sid);
            Console.WriteLine("student name is:" + sname);
        }
    }
       
    internal class ConmstructorOverloading
    {
        static void Main(string[] args)
        {
            student stud = new student(10,"AB");
            stud.Displaydetails();

            student stud1 = new student(10);
            stud1.Displaydetails();

            student stud2 = new student("Ashok");
            stud2.Displaydetails();
        }
    }
}
