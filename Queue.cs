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
            Queue my = new Queue();
            string[] lines = { "1 -  Enqueue", "2 - Dequeue", "3 - GetEnumerator", "4 - Peek", "5 - Equals", "6 - Contains", "7 - Clear", "8 - GetType", "9 - TrimToSize" };
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
                    case 1: zap(ref my); break;
                    case 2: revmove(in my); break;
                    case 3: copy(in my); break;
                    case 4: clear(in my); break;
                    case 5: get_has(ref my); break;
                    case 6: containskey(in my); break;
                    case 7: coy(in my); break;
                    case 8: cy(in my); break;
                    case 9: cop(in my); break;
                }
            }
        }
        public static void zap(ref Queue my)
        {
            string str = Console.ReadLine();
            my.Enqueue(str);
            Console.ReadLine();
        }
        public static void revmove(in Queue my)
        {
            Console.WriteLine(my.Dequeue());
            Console.ReadLine();
        }
        public static void copy(in Queue my)
        {
            Console.WriteLine(my.GetEnumerator());
            Console.ReadLine();
        }
        public static void clear(in Queue my)
        {
            Console.WriteLine(my.Peek());
            Console.ReadLine();
        }
        public static void get_has(ref Queue my)
        {
            string str = Console.ReadLine();
            Console.WriteLine(my.Equals(str));
            Console.ReadLine();
        }
        public static void containskey(in Queue my)
        {
            string str = Console.ReadLine();
            Console.WriteLine(my.Contains(str));
            Console.ReadLine();
        }
        public static void coy(in Queue my)
        {
            my.Clear();
            Console.ReadLine();
        }
        public static void cy(in Queue my)
        {                        
            Console.WriteLine(my.GetType());
            Console.ReadLine();
        }
        public static void cop(in Queue my)
        {
            my.TrimToSize();
            Console.ReadLine();
        }


    }
}
