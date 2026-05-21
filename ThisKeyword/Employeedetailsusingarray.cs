//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThisKeyword
//{
//    class employee
//    {
//        int eid;
//        string ename;
//        double esal;

//        public employee(int eid, string ename, double esal)
//        {
//            this.eid = eid;
//            this.ename = ename;
//            this.esal = esal;
//        }

//        public void Displayemployeedetails()
//        {
//            Console.WriteLine("Employee ID is:" + eid);
//            Console.WriteLine("Employee Name is:" + ename);
//            Console.WriteLine("Employee Salary is:" + esal);
//            Console.WriteLine("---------------------");
//        }

//    }

//    internal class program
//    {
//        static void Main(string[] args)
//        {
            
//            Console.WriteLine("Enter Number of Employees:-");
//            int n = Convert.ToInt32(Console.ReadLine());

//            employee[] emp = new employee[n];
//            for(int i=0; i<n; i++)
//            {
//                Console.WriteLine("Employee Details are:-");

//                Console.WriteLine("Enter Employee ID is:");
//                int eid = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter Employee Name is:");
//                string ename = Console.ReadLine();

//                Console.WriteLine("Enter Employee Salary:-");
//                double esal = Convert.ToDouble(Console.ReadLine());

//                emp[i] = new employee(eid, ename, esal);

//            }

//            Console.WriteLine("Employee Details is:-");
//            for(int i=0; i<emp.Length; i++) 
//            {
//                emp[i].Displayemployeedetails();
//            }
//        }
//    }
//}
