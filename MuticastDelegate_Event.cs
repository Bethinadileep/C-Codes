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
        public event delmethod MyEvent;
        public void RaiseEvent(int a, int b)
        {
            MyEvent(a, b);
            Console.WriteLine("Event Raised");
        }

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
            obj.MyEvent += new delmethod(obj.plus_method1);
            obj.MyEvent += new delmethod(obj.subtract_method1);
            obj.RaiseEvent(20, 10);
            Console.ReadLine();
        }
    }
}
