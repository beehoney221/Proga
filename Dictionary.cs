using System;
using System.Collections;
using System.Drawing;
using System.Dynamic;
using System.Net.NetworkInformation;

namespace arr
{
    class Program
    {
        public static void Main()
        {
            Dictionary<string, string> myal = new Dictionary<string, string>();

            string[] lines = { "1 - Clear", "2 - ContainsKey ", "3 - ContainsValue", "4 - Add", "5 - Equals", "6 - GetEnumerator", "7 - TrimExcess", "8 - GetType", "9 - ToString" };
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
        
        public static void zap(in Dictionary<string, string> myal)
        {
            Console.Clear();
            myal.Clear();
            Console.ReadLine();

        }
        public static void revers(in Dictionary<string, string> myal)
        {
           string num = Console.ReadLine();
            Console.WriteLine(myal.ContainsKey(num));
            Console.ReadLine();
        }
        public static void copy(in Dictionary<string, string> myal)
        {
            string num = Console.ReadLine();
            Console.WriteLine(myal.ContainsKey(num));
            Console.ReadLine();
        }
        public static void clear(ref Dictionary<string, string> myal)
        {
           string num = Console.ReadLine();
            myal.Add(num, num);
            Console.ReadLine();
        }
        public static void ind(in Dictionary<string, string> myal)
        {
           string num = Console.ReadLine();
            Console.WriteLine(myal.Equals(num));
            Console.ReadLine();
        }
        public static void sort(in Dictionary<string, string> myal)
        {
            Console.WriteLine(myal.GetEnumerator());
            Console.ReadLine();
        }
        public static void bin(in Dictionary<string, string> myal)
        {
            myal.TrimExcess();
            Console.ReadLine();
        }
        public static void removerange(in Dictionary<string, string> myal)
        {

            Console.WriteLine(myal.GetType());
            Console.ReadLine();
        }
        public static void insertrange(ref Dictionary<string, string> myal)
        {
            Console.WriteLine(myal.ToString());
            Console.ReadLine();
        }
    }
}
