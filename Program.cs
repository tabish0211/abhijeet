using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhijeetConsole
{
    class Program
    {

        static void Main()
        {
           // C obj = new C();//m from A--,m from b--m from c
            //destructor go from child to parent


            D d = new D(2);
            Console.ReadLine();



        }    
        
    
    }


    class A
    {
        private int id;


        public A()
        {
            Console.WriteLine("m from A");
        }

        public A(int id)
        {
            // TODO: Complete member initialization
            this.id = id;
        }

        ~A()
        {
            Console.WriteLine("m from A des");
        }
    }

    class B : A {

        public B()
        {
            Console.WriteLine("m from B");
        }

         ~B()
        {
            Console.WriteLine("m from B des");
        }
    }

    class C : B
    {

        public C()
        {
            Console.WriteLine("m from C");
        }

         ~C()
        {
            Console.WriteLine("m from C des");
        }

    }


    class D : A {

        public D(int id):base(id)
        {

        }
    }

                

}
