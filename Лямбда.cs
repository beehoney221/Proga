using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lambda
{
    delegate double Del(List<double> l);
    class Lam
    {
        public Del min = (l) => { l.Sort(); return l[0]; };
        public Del max = (l) => { l.Sort(); l.Reverse(); return l[0]; };
        public Del sum = (l) => 
        {
            double k = 0;
            foreach (double s in l) { k += s; }
            return k;
        };
        public Del mult = (l) =>
        {
            double k = 1;
            foreach (double s in l) { k *= s; }
            return k;
        };
    }
    class Program
    {
        public static void Main()
        {
            Lam l = new Lam();
            double x;
            List<double> elem = new List<double>();
            Console.WriteLine("Введите три числа");
            for (int i = 0; i < 3; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                elem.Add(x);
            }
            Console.Clear();
            Console.WriteLine("Минимальное - {0}", l.min(elem));
            Console.WriteLine("Максимальное - {0}", l.max(elem));
            Console.WriteLine("Сумма - {0}", l.sum(elem));
            Console.WriteLine("Произведение - {0}", l.mult(elem));
            Console.WriteLine("Среднее арифметическое - {0}", l.sum(elem) / 3);
        }
    }
}
