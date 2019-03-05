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
            if (args.Length >= 2)
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine(args[0] + " is " + args[1]);
            }
            else
            {
                Console.WriteLine("Input Wrong");
            }

            //instantiation method
            HelloWorld myHelloWorld=new HelloWorld();
            myHelloWorld.SayHello1();
            myHelloWorld.SayHello1(args);

            //static method
            HelloWorld.SayHello2();
            HelloWorld.SayHello2(args);
        }
    }
}
