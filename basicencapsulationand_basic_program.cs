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
//            //customer obj--stack--Address of heap belwo object
//            //unique
//            Customer obj = new Customer();//Heap1
//            new Customer();//2//heap
//            new Customer();//3//heap


//            (new Customer()).Id = 2001;
//            Console.WriteLine((new Customer()).Id);
//            //  obj.Set(1001);
//            //int id = obj.Get();

//            obj.Id = 1001;//settter;
//            int id = obj.Id;//getter
//            Console.WriteLine(id);
//            Console.ReadLine();


//            //1.state---properties---Id
//            //2.Behaviour--display()
//            //uniquenss--unique--new statement---we are ctreating new memory

//        }



//    }

//    //Encapsulation

//    class Customer
//    {

//        public void display()
//        { }
//        //private int _id;//deafult value is 0


//        ////C# 2.0

//        //public int Id
//        //{
//        //    get { 

//        //        return _id;
//        //    }

//        //    set{

//        //        _id = value;
//        //    }
//        //}


//        //C# 4.0

//        public int Id { get; set; }

//        public string Name { get; set; }

//        //public void Set(int id)
//        //{

//        //    _id = id;

//        //}

//        //public int Get()
//        //{

//        //    return _id;

//        //}

//    }



//}
