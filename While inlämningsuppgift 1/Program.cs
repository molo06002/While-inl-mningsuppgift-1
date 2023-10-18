// See https://aka.ms/new-console-template for more information
using System;
namespace inlämnings_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 1;
            int tal2 = 200;
            int tal3 = 1000;
            while (tal < 30)
            {
                tal++;
                Console.WriteLine(tal);
            }
            while (tal2 > 180)
            {
                tal2--;
                Console.WriteLine(tal2);
            }
            for (tal3 = 1000; tal3 <= 1400; tal3 += 50)
            {
                Console.WriteLine(tal3);
            }
            
        }
    }
}