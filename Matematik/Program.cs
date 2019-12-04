using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen!");
            LineærFunktion f = new LineærFunktion(2, 3);
            double fv = f.Funktionsværdi(10);
            double x = f.BestemX(43);

            Console.WriteLine(fv);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
