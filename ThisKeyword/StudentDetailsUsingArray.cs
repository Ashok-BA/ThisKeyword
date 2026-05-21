//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThisKeyword
//{
//    class student
//    {
//        int id;
//        string name;

//        public student(int id, string name)
//        {
//            this.id = id;
//            this.name = name;
//        }

//        public void displaydetails()
//        {
//            Console.WriteLine("Student ID is:" + id);
//            Console.WriteLine("student Name is:" + name);
//            Console.WriteLine("------------------------");
//        }
//    }

//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number of students:");
//            int n = Convert.ToInt32(Console.ReadLine());

//            student[] stud = new student[n];
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("Enter Student Id:");
//                int id = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter Student Name:");
//                string name = Console.ReadLine();

//                stud[i] = new student(id, name);
//            }

//            Console.WriteLine("studetns Details are:-");
//            for (int i = 0; i < stud.Length; i++)
//            {
//                stud[i].displaydetails();

//            }
//        }
//    }
//}
