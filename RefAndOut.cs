//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AbhijeetConsole
//{
//    class RefAndOut
//    {
//        static void Main(string[] args)
//        {
//            //ref vs out

//            Program obj = new Program();
//            Console.WriteLine("Enter num1");
//            int x = Convert.ToInt32(Console.ReadLine());//1001
//            Console.WriteLine("Enter num2");
//            int y = Convert.ToInt32(Console.ReadLine());//1002
//            // obj.Sum(x,y);//actaul argument--pass by value
//            obj.Sum(ref x, ref y);//pass by reference

//            //out demo
//            int result;//calculation
//            obj.SumWithOut(2, 3, out result);
//            Console.WriteLine(result);
//            Console.ReadLine();


//        }
//        //2+2 =varaibales
//        public void Sum(int x, int y)//formal argument
//        {

//            int sum = x + y;
//            Console.WriteLine(sum);
//        }

//        //2 varaibles --address ---o to same memory location caluclation will be done---1001,10002--addresses
//        public void Sum(ref int x, ref  int y)
//        {
//            //x = 2;
//            int sum = x + y;
//            Console.WriteLine(sum);
//        }

//        //many clients
//        public void SumWithOut(int x, int y, out int result)
//        {
//            //x = 2;
//            result = x + y;

//        }
//    }
//}
