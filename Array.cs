using System;
using System.Dynamic;
using System.Net.NetworkInformation;

namespace arr
{
    class Program
    {
        public static void Main()
        {
            Array myArr = Array.CreateInstance(typeof(Int32), 10);
            string[] lines = { "1 - Заполнениие ", "2 - Reverse", "3 - CopyTo", "4 - Clear", "5 - IndexOf", "6 - Sort", "7 - Binar", "8 - GetValue", "9 - GetLength" };
            int code;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                code = Convert.ToInt32(Console.ReadLine());
                switch (code)
                {
                    case 1: zap(ref myArr); break;
                    case 2: revers(in myArr); break;
                    case 3: copy(in myArr); break;
                    case 4: clear(in myArr); break;
                    case 5: ind(in myArr); break;
                    case 6: sort(in myArr); break;
                    case 7: bin(in myArr); break;
                    case 8: get_value(in myArr); break;
                    case 9: get_len(ref myArr); break;
                }
            }
        }
        public static void zap(ref Array myArr)
        {
            Console.Clear();
            Console.WriteLine("Было:");
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            for (int i = myArr.GetLowerBound(0);i<= myArr.GetUpperBound(0);i++)
            {
                myArr.SetValue(5 * i, i);
            }
            myArr.SetValue(1, 0);
            Console.WriteLine();
            Console.WriteLine("Стало:");
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void revers(in Array myArr)
        {
            Console.WriteLine("Было:");
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Стало:");
            Array.Reverse(myArr, 4, 5);
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void copy(in Array myArr)
        {
            Console.WriteLine("Исходный массив:");
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Второй массив до копирования");
            Array myArr_1 = Array.CreateInstance(typeof(Int32), 13);
            myArr_1.SetValue(10, 0);
            myArr_1.SetValue(78, 1);
            myArr_1.SetValue(932, 2);
            foreach (int i in myArr_1)
            {
                Console.Write(i + "\t");
            }
            myArr.CopyTo(myArr_1, 3);
            Console.WriteLine();
            Console.WriteLine("Второй массив после копирования");
            foreach (int i in myArr_1)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void clear(in Array myArr)
        {
            Console.WriteLine("Было:");
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Array.Clear(myArr, 4, 4);
            Console.WriteLine();
            Console.WriteLine("Стало:");
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void ind(in Array myArr)
        {
            Console.WriteLine("Выводит индекс числа 25");
            int in_dex = Array.IndexOf(myArr, 25);
            Console.WriteLine(in_dex);
            Console.ReadLine();
        }
        public static void sort(in Array myArr)
        {
            Console.WriteLine("Исходный массив:");
            myArr.SetValue(789, 0);
            myArr.SetValue(69, 1);
            myArr.SetValue(9964, 2);
            myArr.SetValue(45, 5);
            myArr.SetValue(1, 9);
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Array.Sort(myArr);
            Console.WriteLine("Массив после сортировки");
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void bin(in Array myArr)
        {

            Console.WriteLine("Исходный массив:");
            foreach (int i in myArr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
            int innn = 45;
            int in_dex = Array.BinarySearch(myArr, innn );
            if (in_dex < 0)
            {Console.WriteLine("Элемент 45 ненайден");}
            else { Console.WriteLine("Элемент 45 найден"); }
            Console.ReadLine();
        }
        public static void get_value(in Array myArr)
        {
            Console.WriteLine("Введите индекс элемента");
            int in_dex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myArr.GetValue(in_dex));
            Console.ReadLine();
        }
        public static void get_len(ref Array myArr)
        {
            Console.Write("Длина массива: ");
            Console.WriteLine(myArr.GetLength(0));
            Console.ReadLine();
        }
    }
}
