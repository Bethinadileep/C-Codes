using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Muticast Delegate
    public delegate void delmethod(int x, int y);
    public class TestMultipleDelegate
    {
        public void plus_method1(int x, int y)
        {
            Console.WriteLine("You are in Plus Method");
            Console.WriteLine(x + y);
        }
        public void subtract_method1(int x, int y)
        {
            Console.WriteLine("You are in Subtract Method");
            Console.WriteLine(x - y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestMultipleDelegate obj = new TestMultipleDelegate();
            //Multicast
            delmethod del1 = new delmethod(obj.plus_method1);
            del1 += new delmethod(obj.subtract_method1);

            del1(70, 60);

            del1 -= new delmethod(obj.plus_method1);
            del1(25, 14);
            Console.ReadLine();
        }
    }
}
