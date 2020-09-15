using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 20; i++)
            {
                
                if(i%3 == 0)
                {
                    sum = sum + i;
                }
                
            }
            Console.WriteLine($"Addition of integers is  { sum}");
            Console.ReadKey();
        }
       
    }
}
