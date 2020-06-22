using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 0;
            while(i < 3) 
            {
                Console.Beep(2000, 80); 
                Console.Beep(1000, 80); 
                i++; 
            }                    

            Console.WriteLine("Austin was here too! Beep Boop");
        }
    }
}
