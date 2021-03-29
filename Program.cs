using System;

namespace Generics_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterService<string> probjectService = new PrinterService<string>();

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                probjectService.AddValue(x);
            }

            //int a = (int)PrinterService.First();
            //int b = a + 2;
            //Console.WriteLine(b);

            probjectService.Print();
            Console.WriteLine("Firts: " + probjectService.First());
        }
    }
}
