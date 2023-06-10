using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lambda
{
    delegate double Del(double x, double y, double z);
    class Lam
    {
        public Del max = (x, y, z) => Math.Max(x, Math.Max(y, z));
        public Del min = (x, y, z) => Math.Min(x, Math.Min(y, z));
        public Del sum = (x, y, z) => x + y + z;
        public Del mult = (x, y, z) => x * y * z;
        public Del sa = (x, y, z) => (x + y + z) / 3;
    }
    class Program
    {
        public static void Main()
        {
            Lam l = new Lam();
            Console.WriteLine("Введите три числа");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z = ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Минимальное - {0}", l.min(x, y, z));
            Console.WriteLine("Максимальное - {0}", l.max(x, y, z));
            Console.WriteLine("Сумма - {0}", l.sum(x, y, z));
            Console.WriteLine("Произведение - {0}", l.mult(x, y, z));
            Console.WriteLine("Среднее арифметическое - {0}", l.sa(x, y, z));
        }
    }
}
