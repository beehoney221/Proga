using System;
namespace Lambda
{
    delegate void Del(List<double> l);
    class Program
    {
        public static void Main()
        {
            List<double> elem = new List<double>();
            double s = 0;
            double um = 1;
            Console.WriteLine("Введите три числа");
            for (int i = 0; i < 3; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                elem.Add(a);
            }
            Del min = (l) =>
            {
                elem.Sort();
                Console.WriteLine(l[0]);
            };
            Del max = (l) =>
            {
                elem.Sort();
                elem.Reverse();
                Console.WriteLine(l[0]);
            };
            Del sum = (l) =>
            {
                foreach (double e in l)
                {
                    s += e;
                }
                Console.WriteLine(s);
            };
            Del pr = (l) =>
            {
                foreach (double p in l)
                {
                    um *= p;
                }
                Console.WriteLine(um);
            };
            Del sa = (l) =>
            {
                Console.WriteLine(s/3);
            };
            Console.Write("Минимальное - ");
            min(elem);
            Console.Write("Максимальное - ");
            max(elem);
            Console.Write("Сумма - ");
            sum(elem);
            Console.Write("Среднее арифметическое - ");
            sa(elem);
        }
    }
}
