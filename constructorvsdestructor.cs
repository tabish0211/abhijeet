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
//            Customer obj = new Customer();
//            Console.WriteLine(obj.Id);
//            //ICICI
//            Customer objParam = new Customer(2001, "NA");
//            Console.WriteLine(objParam.Id);

//            //HDFC
//            Customer objParamHdfc = new Customer(3001, "HD");
//            Console.WriteLine(objParamHdfc.Id);

//            Console.ReadLine();
//        }



//    }

//    //constructor

//    class Customer
//    {

//        public int Id { get; set; }

//        public string Name { get; set; }


//        //by default --private
//        public Customer()
//        {
//            Id = 1001;
//            Name = "Default";

//        }

//        public Customer(int id)
//        {
//            Id = id;

//        }

//        public Customer(int id, string name)
//            : this(id)
//        {
//            Name = name;

//        }

//        //CLR--we dont have control--Overloaded
//        ~Customer()
//        {

//            Console.WriteLine("memory cleaning");

//        }

//    }



//}
