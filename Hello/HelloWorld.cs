using System;

namespace Hello
{
    class HelloWorld
    {
        public void SayHello1()
        {
            Console.WriteLine("Hello World! in a instantiation method.");
        }

        public void SayHello1(string[] str)
        {
            if (str.Length >= 2)
            {
                Console.Write("Hello World! in a instantiation method with command-line arguments: ");
                Console.WriteLine(str[0] + " is " + str[1]);
            }else
            {
                Console.WriteLine("Input Wrong");
            }
        }

        public static void SayHello2()
        {
            Console.WriteLine("Hello World! in a static method.");
        }

        public static void SayHello2(string[] str)
        {
            if (str.Length >= 2)
            {
                Console.Write("Hello World! in a static method with command-line arguments: ");
                Console.WriteLine(str[0] + " is " + str[1]);
            }
            else
            {
                Console.WriteLine("Input Wrong");
            }
        }
    }
}