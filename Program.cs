using System;

namespace FirstApp
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine($"ВВЕДИТЕ КОЭФФИЦИЕНТЫ");
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Calculator.Diskr(a, b, c);
        }
    }
    class Calculator
    {
        public static void Diskr(int x, int y, int z)
        {
            double d = y * y - 4 * x * z;
            if (d < 0)
                Console.WriteLine("ДИСКРИМИНАНТ МЕНЬШЕ НУЛЯ,НЕВЕРНЫЕ КОЭФФЦИЕНТЫ");
            else
            {
                Console.WriteLine("х1 = " + (-y + Math.Sqrt(d)) / (2 * x));
                Console.WriteLine("х2 = " + (-y - Math.Sqrt(d)) / (2 * x));
            }
        }
       
    }
}
