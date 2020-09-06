//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AbhijeetConsole
//{
//    class Program
//    {
//        static void Main()
//        {

//            //is vs as 

//            //primitive datatypes---int float char----stack---value types
//            //reference types---class 
//            ///Program obj;-----reference of program---addresss----heap
//            //Program obj = new Program();//new Program()--heap

//            //to check the compatibilty of two reference type to each other we can is keyword

//            Program obj = new Program();
//            Program obj1 = new Program();
//            Employee emp = new Employee();
//            object o = new object();

//            bool IsCompatible = emp is Program;
//            if (IsCompatible)
//            {
//                var obj2 = o as Program;//converting one reference type to another;

//            }

//            Console.WriteLine(IsCompatible);

//            Console.ReadLine();
//        }
//    }


//    class Employee
//    {

//    }

//}
