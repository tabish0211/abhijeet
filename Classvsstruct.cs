//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AbhijeetConsole
//{
//   /*
//         * classes are reference types and structs are value types
//           structures do not support inheritance
//           structures cannot have default constructor
//         * */
//    class A{

//        static void Main()
//        {
//            //stack memory--always be created
//            Books Book1 = new Books();
//            Book1.display();

//            //heap
//            MyBooks bk = new MyBooks();
//            bk.display();

//        }
    

//    }
        
    


//    struct Books
//    {
//        private string title;
//        private string author;
//        private string subject;
//        private int book_id;

//        //public Books()
//        //{

//        //}
//        public void getValues(string t, string a, string s, int id)
//        {
//            title = t;
//            author = a;
//            subject = s;
//            book_id = id;
//        }

//        public void display()
//        {
//            Console.WriteLine("Title : {0}", title);
//            Console.WriteLine("Author : {0}", author);
//            Console.WriteLine("Subject : {0}", subject);
//            Console.WriteLine("Book_id :{0}", book_id);
//        }
//    };


//    class MyBooks
//    {
//        string title;

//        public MyBooks()
//        {

//        }
//        public void getValues(string t)
//        {
//            title = t;
          
//        }


//        public void display()
//        {
//            Console.WriteLine("Title : {0}", title);
           
//        }
    
//    }

//}
