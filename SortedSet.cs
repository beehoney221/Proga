using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Net.NetworkInformation;

namespace arr
{
    class Program
    {
        public static void Main()
        {
            SortedSet<string> myal = new SortedSet<string>();

            string[] lines = { "1 - Clear", "2 - GetType ", "3 - ContainsValue", "4 - Add", "5 - Contains", "6 - Remove", "7 - ToString", "8 - GetEnumerator", "9 - Equals" };
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
                    case 4: clear(ref myal); break;
                    case 5: ind(in myal); break;
                    case 6: sort(in myal); break;
                    case 7: bin(in myal); break;
                    case 8: removerange(in myal); break;
                    case 9: insertrange(ref myal); break;
                  

                }
            }
        }
        
        public static void zap(in SortedSet<string> myal)
        {
            Console.Clear();
            myal.Clear();
            Console.ReadLine();

        }
        public static void revers(in SortedSet<string> myal)
        {
            Console.WriteLine(myal.GetType());
            Console.ReadLine();
        }
        public static void copy(in SortedSet<string> myal)
        {
            string num = Console.ReadLine();
            Console.WriteLine(myal.Contains(num));
            Console.ReadLine();
        }
        public static void clear(ref SortedSet<string> myal)
        {
           string num = Console.ReadLine();
            myal.Add(num);
            Console.ReadLine();
        }
        public static void ind(in SortedSet<string> myal)
        {
            string num = Console.ReadLine();
            Console.WriteLine(myal.Contains(num));
            Console.ReadLine();
        }
        public static void sort(in SortedSet<string> myal)
        {
            string num = Console.ReadLine();
            myal.Remove(num);
            Console.ReadLine();
        }
        public static void bin(in SortedSet<string> myal)
        {
            Console.WriteLine(myal.ToString());
            Console.ReadLine();
        }
        public static void removerange(in SortedSet<string> myal)
        {

            Console.WriteLine(myal.GetEnumerator());
            Console.ReadLine();
        }
        public static void insertrange(ref SortedSet<string> myal)
        {
           string num = Console.ReadLine();
            Console.WriteLine(myal.Equals(num));
            Console.ReadLine();
        }
    }
}
