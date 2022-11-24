using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void delmethod();
    class P
    {
        public static void display()
        {
            Console.WriteLine("Hello!");
        }
        public static void show()
        {
            Console.WriteLine("Hi!");
        }
        public void print()
        {
            Console.WriteLine("Print!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            P obj = new P();
            delmethod del1 = new delmethod(P.show);
            delmethod del2 = new delmethod(P.display);
            delmethod del3 = obj.print;
            del1();
            del2();
            del3();
            Console.ReadLine();
        }
    }
}
