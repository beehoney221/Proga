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
            Stack my = new Stack();
            string[] lines = { "1 - Clear ", "2 - Contains", "3 - Peek", "4 - Pop", "5 - Push", "6 - Задача про скобки"};
            int code;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 6; i++)
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
                }
            }
        }
        public static void zap(ref Stack my)
        {
            my.Clear();
            Console.ReadLine();
        }
        public static void revmove(in Stack  my)
        {
            string num = Console.ReadLine();
            Console.WriteLine(my.Contains(num));
            Console.ReadLine();
        }
        public static void copy(in Stack my)
        {
            Console.WriteLine(my.Peek());
            Console.ReadLine();
        }
        public static void clear(in Stack my)
        {
            Console.WriteLine(my.Pop());
            Console.ReadLine();
        }
        public static void get_has(ref Stack my)
        {
            string num = Console.ReadLine();
            my.Push(num);
            Console.ReadLine();
        }
        public static void containskey(in Stack my)
        {
            object skob;
            int cnt = 0;
            string num = Console.ReadLine();
            foreach (var sk in num)
            {
                if (sk == '(' || sk == '{' || sk == '[')
                {
                    my.Push(sk);
                }
                else if (my.Count != 0)
                {
                    skob = my.Peek();
                    if (sk == ')' && skob is '(')
                    {
                        my.Pop();
                    }
                    if (sk == ']' && skob is '[')
                    {
                        my.Pop();
                    }
                    if (sk == '}' && skob is '{')
                    {
                        my.Pop();
                    }
                }
                else
                {
                    Console.WriteLine("Нет");
                    Console.ReadKey();
                    cnt++;
                    break;
                }
            }
            if (cnt == 0 && my.Count == 0)
            {
                Console.WriteLine("Да");
                Console.ReadLine();
            }
            else if (cnt == 0 && my.Count != 0)
            {
                Console.WriteLine("Нет");
                Console.ReadLine();
            }
        }

    }
}
