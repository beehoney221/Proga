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
            Hashtable my = new Hashtable();
            string[] lines = { "1 - Add ", "2 - Revmove", "3 - CopyTo", "4 - Clear", "5 - GerHash", "6 - ContainsKey", "7 - ContainsValues", "8 - Synchronized", "9 - GetEnumerator" };
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
                    case 7: containsValues(in my); break;
                    case 8: synchronized(in my); break;
                    case 9: get_len(in my); break;
                }
            }
        }
        public static void zap(ref Hashtable my)
        {
            Console.Clear();
            my.Add("Омск", "Паша");
            my.Add("Москва", "Саша");
            my.Add("Санкт-Петербург", "Олег");
            my.Add("Гусь Хрустальный", "Антон");
            my.Add("Лондон", "Майкл");
            my.Add("Стамбул", "Святополк");
            my.Add("Томск", "Гоша");
            Console.WriteLine("Стало:");
            ICollection c = my.Keys;
            foreach (string i in c)
            {
                Console.WriteLine(i + ": " + my[i]);
            }
            
            Console.ReadLine();
        }
       public static void revmove(in Hashtable my)
        {
            Console.WriteLine("Было:");
            ICollection c = my.Keys;
            foreach (string i in c)
            {
                Console.WriteLine(i + ": " + my[i]);
            }
            Console.WriteLine();
            my.Remove("Лондон");
            my.Remove("Стамбул");
            Console.WriteLine("Стало:");
            ICollection a = my.Keys;
            foreach (string i in a)
            {
                Console.WriteLine(i + ": " + my[i]);
            }
            Console.ReadLine();
        }
        public static void copy(in Hashtable my)
        {
            Console.WriteLine("Исходная таблица:");
            ICollection c = my.Keys;
            foreach (string i in c)
            {
                Console.WriteLine(i + ": " + my[i]);
            }
            
            Array myArr_1 = Array.CreateInstance(typeof(String), 10);
            myArr_1.SetValue("Темно", 0);
            myArr_1.SetValue("Светло", 1);
            myArr_1.SetValue("Ярко", 2);
            my.Values.CopyTo(myArr_1, 3);
            Console.WriteLine();
            Console.WriteLine("Массив");
            foreach (string i in myArr_1)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
        public static void clear(in Hashtable my)
        {
            Console.WriteLine("Было:");
            ICollection c = my.Keys;
            foreach (string i in c)
            {
                Console.WriteLine(i + ": " + my[i]);
            }
            my.Clear();
            Console.WriteLine();
            Console.WriteLine("Стало:");
            ICollection a = my.Keys;
            foreach (string i in a)
            {
                Console.WriteLine(i + ": " + my[i]);
            }
            Console.ReadLine();
        }
        public static void get_has(ref Hashtable my)
        {
            Console.WriteLine("Выводит hash задоного значения");
            object in_dex = Console.ReadLine();
            Console.WriteLine(my[in_dex].GetHashCode());
            Console.ReadLine();
        }
        public static void containskey(in Hashtable my)
        {
            Console.WriteLine("Введите значения для проверки ключа");
            string in_dex = Console.ReadLine();
            Console.WriteLine(my.ContainsKey(in_dex));
            Console.ReadLine();
        }
        public static void containsValues(in Hashtable my)
        {
            Console.WriteLine("Введите значения для проверки ");
            string in_dex = Console.ReadLine();
            Console.WriteLine(my.ContainsValue(in_dex));
            Console.ReadLine();
        }
        public static void synchronized(in Hashtable my)
        {

            Console.WriteLine("Синхронизация:");
            Hashtable my_1 = Hashtable.Synchronized(my);
            ICollection c = my_1.Keys;
            foreach (string i in c)
            {
                Console.WriteLine(i + ": " + my_1[i]);
            }

            Console.ReadLine();
        }
        public static void get_len(in Hashtable my)
        {
            IDictionaryEnumerator denum = my.GetEnumerator();
            DictionaryEntry dentry;
            while (denum.MoveNext())
            {
                dentry = (DictionaryEntry) denum.Current;
                Console.WriteLine("{0}:{1}",dentry.Key, dentry.Value);
            }
            Console.ReadLine();
        }
    }
}
