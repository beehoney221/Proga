using System;
namespace Inter
{
    delegate double Operation(double a, double b);
    interface IMath
    {
        double Sum(double a, double b);
        double Sub(double a, double b);
        double Mult(double a, double b);
        double Div(double a, double b);
    }
    class Math : IMath
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
    class Program
    {
        public static void Main()
        {
            Math m = new Math();
            List<string> oper = new List<string>() { "1 - Сложение", "2 - Вычитание", "3 - Умножение", "4 - Деление", "5 - Выход"};
            double a, b;
            while (true)
            {
                Console.Clear();
                foreach (string st in oper)
                {
                    Console.WriteLine(st);
                }
                int code = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (code)
                {
                    case 1: Console.WriteLine("> Сложение > Введите переменные");
                        Console.Write("a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("> Сложение > Ответ");
                        Console.Write(a + " + " + b + " = ");
                        Operation sum = m.Sum;
                        Console.WriteLine(sum.Invoke(a, b));
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("> Вычитание > Введите переменные");
                        Console.Write("a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("> Вычитание > Ответ");
                        Console.Write(a + " - " + b + " = ");
                        Operation sub = m.Sub;
                        Console.WriteLine(sub.Invoke(a, b));
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("> Умножение > Введите переменные");
                        Console.Write("a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("> Умножение > Ответ");
                        Console.Write(a + " * " + b + " = ");
                        Operation mul = m.Mult;
                        Console.WriteLine(mul.Invoke(a, b));
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("> Деление > Введите переменные");
                        Console.Write("a = ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b = ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        if (b != 0)
                        {
                            Console.WriteLine("> Деление > Ответ");
                            Console.Write(a + " / " + b + " = ");
                            Operation div = m.Div;
                            Console.WriteLine(div.Invoke(a, b));
                        }
                        else Console.WriteLine("На нуль делить нельзя!");
                        Console.ReadLine();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
