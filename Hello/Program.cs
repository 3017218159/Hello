using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hello World!");
            Console.ResetColor();
            Console.WriteLine("{0} is {1}", args[0], args[1]);

            //instantiation method
            HelloWorld myHelloWorld=new HelloWorld();
            myHelloWorld.SayHello1();

            //static method
            HelloWorld.SayHello2();
        }
    }
}
