using System;
using System.Collections;
using System.Dynamic;
using System.Net.NetworkInformation;

namespace arr
{
    class Program
    {
        public static void Main()
        {
            List<Int32> myal = new List<Int32>();
            myal.Add(99);
            myal.Add(78);
            myal.Add(74147);
            myal.Add(5960);
            myal.Add(14);
            myal.Add(5);
            myal.Add(88);
            myal.Add(46);
            myal.Add(6);
            myal.Add(17);
            myal.Add(560);
            string[] lines = { "1 - AddRange ", "2 - Reverse", "3 - CopyTo", "4 - Clear", "5 - IndexOf", "6 - Sort", "7 - Binar", "8 - RemoveRange", "9 - InsertRange" };
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
                    case 1: zap(in myal); break;
                    case 2: revers(in myal); break;
                    case 3: copy(in myal); break;
                    case 4: clear(in myal); break;
                    case 5: ind(in myal); break;
                    case 6: sort(in myal); break;
                    case 7: bin(in myal); break;
                    case 8: removerange(in myal); break;
                    case 9: insertrange(ref myal); break;
                }
            }
        }
        public static void zap(in List<Int32> myal)
        {
            Console.Clear();
            Console.WriteLine("Было:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            List<Int32> myal_1 = new List<Int32>();
            myal_1.Add(8);
            myal_1.Add(7);
            myal_1.Add(56);
            myal.AddRange(myal_1);
            Console.WriteLine();
            Console.WriteLine("Стало:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }

            Console.ReadLine();
        }
        public static void revers(in List<Int32> myal)
        {
            Console.WriteLine("Было:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Стало:");
            myal.Reverse();
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void copy(in List<Int32> myal)
        {
            Console.WriteLine("Исходный cписок:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Второй массив до копирования");
            Int32[] myArr_1 = new int[17];
            myArr_1.SetValue(179, 0);
            myArr_1.SetValue(10, 1);
            myArr_1.SetValue(25, 2);
            foreach (int i in myArr_1)
            {
                Console.Write(i + "\t");
            }
            myal.CopyTo(myArr_1, 3);
            Console.WriteLine();
            Console.WriteLine("Второй массив после копирования");
            foreach (int i in myArr_1)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void clear(in List<Int32> myal)
        {
            Console.WriteLine("Было:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            myal.Clear();
            Console.WriteLine();
            Console.WriteLine("Стало:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void ind(in List<Int32> myal)
        {
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.Write("Выводит индекс числа 99 : ");
            int in_dex = myal.IndexOf(99);
            Console.Write(in_dex);
            Console.ReadLine();
        }
        public static void sort(in List<Int32> myal)
        {
            Console.WriteLine("Исходный массив:");
            myal.Add(789);
            myal.Add(69);
            myal.Add(9964);
            myal.Add(45);
            myal.Add(1);
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            myal.Sort();
            Console.WriteLine("Массив после сортировки");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void bin(in List<Int32> myal)
        {
            myal.Sort();
            Console.WriteLine("Исходный массив:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            
            Console.WriteLine("Введите элемент списка");
            int innn = Convert.ToInt32(Console.ReadLine());
            int in_dex = myal.BinarySearch(innn);
            if (in_dex < 0)
            { Console.WriteLine("Элемент ненайден"); }
            else { Console.WriteLine("Элемент найден"); }
            Console.ReadLine();
        }
        public static void removerange(in List<Int32> myal)
        {

            Console.WriteLine("ДО:");

            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            myal.RemoveRange(3, 5);
            Console.WriteLine();
            Console.WriteLine("После:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void insertrange(ref List<Int32> myal)
        {
            Console.WriteLine("ДО:");

            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            List<Int32> myal_1 = new List<Int32>();
            myal_1.Add(8);
            myal_1.Add(7);
            myal_1.Add(56);
            myal.InsertRange(4, myal_1);
            Console.WriteLine();
            Console.WriteLine("После:");
            foreach (int i in myal)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
