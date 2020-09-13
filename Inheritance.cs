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
//            IPhone obj = new IPhone();
//            IPhone11 obj1 = new IPhone11();

//            string name = "iphone 6";
//            string color = "Black";
//            int price = 45000;
//            string type = "iphone 6";

//            obj.Name = name;
//            obj.Color = color;
//            obj.Price = price;
//            obj.Type = type;

//            int disc = obj.Discount();
//            Console.WriteLine(disc);
//            Console.ReadLine();



//        }



//    }



//    class Product
//    {

//        public int Price { get; set; }
//        public string Type { get; set; }
//        public string Name { get; set; }
//    }

//    class service : Product
//    {
//        public int NetSize { get; set; }
//    }
//    class Hardware : Product
//    {
//        public string Color { get; set; }
//    }



//    class IPhone : Hardware
//    {



//        public virtual int Discount()
//        {

//            return 10;

//        }



//    }

//    class IPhone7 : IPhone
//    {

//        public override int Discount()
//        {
//            return 15;
//        }

//    }


//    class IPhone11 : IPhone
//    {

//        public override int Discount()
//        {
//            return 20;
//        }

//    }



//}
