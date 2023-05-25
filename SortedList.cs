using System;
using System.Collections;

namespace Collection_SList
{
    class Program
    {
        public static void Main()
        {
            //создали
            SortedList sl = new SortedList();

            //менюшка
            Console.WriteLine("SortedList\n");
            string[] lines = { "1 - Добавить/удалить\t(в списке пусто - надо зайти)", "2 - Отобразить", "3 - Контэинс", "4 - Гет/Сет", "5 - Индекс", "6 - Удалить всё", "7 - Выход" };
            int code;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                code = Convert.ToInt32(Console.ReadLine());
                switch (code)
                {
                    case 1: AddRemove(ref sl); break;
                    case 2: Show(ref sl); break;
                    case 3: Contains(ref sl); break;
                    case 4: GetSet(ref sl); break;
                    case 5: Index(ref sl); break;
                    case 6: Clear(ref sl); break;
                    case 7: Exit(); break;
                }
            }
        }

        public static void AddRemove(ref SortedList sl)
        {
            int code;
            bool l = true;
            while (l)
            {
                Console.Clear();
                Console.WriteLine("1 - Add\n2 - Remove\n3 - RemoveAt\nЛюбое число - Показать и выйти");
                code = Convert.ToInt32(Console.ReadLine());
                switch (code)
                {
                    case 1: 
                        Console.WriteLine("Add\nВведите ключ.");
                        string k = Console.ReadLine();
                        Console.WriteLine("Введите значение.");
                        string v = Console.ReadLine();
                        sl.Add(k, v);
                        break;
                    case 2: 
                        Console.WriteLine("Remove\nВведите ключ.");
                        string k1 = Console.ReadLine();
                        sl.Remove(k1);
                        break;
                    case 3:
                        Console.WriteLine("RemoveAt\nВведите индекс.");
                        int i = Convert.ToInt32(Console.ReadLine());
                        if (i < sl.Count) sl.RemoveAt(i);
                        else Console.WriteLine("Нет элемента с таким индексом.");
                        break;
                    default: l = false;
                        break;
                }
            }
            Show(ref sl);
        }
        public static void Show(ref SortedList sl)
        {
            Console.Clear();
            Console.WriteLine("Вывод\n");
            ICollection c = sl.Keys;
            foreach (var str in c)
            {
                Console.WriteLine(str + ": " + sl[str]);
            }
            Console.WriteLine("\nНужно что-то нажать...");
            Console.ReadLine();
        }
        public static void Contains(ref SortedList sl)
        {
            bool l = true;
            while (l)
            {
                Console.Clear();
                Console.WriteLine("1 - ContainsKey\n2 - ContainsValue\nЛюбое число - Выйти");
                int code = Convert.ToInt32(Console.ReadLine());
                switch (code)
                {
                    case 1:
                        Console.WriteLine("ContainsKey\nВведите ключ.");
                        string k = Console.ReadLine();
                        if (sl.ContainsKey(k) == true) Console.WriteLine("Такой ключ есть...\n\t{0}: {1}", k, sl[k]);
                        else Console.WriteLine("Такого ключа нет...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("ContainsValue\nВведите значение.");
                        string v = Console.ReadLine();
                        if (sl.ContainsValue(v) == true) Console.WriteLine("Такое значение есть...\n\t{0}: {1}", (sl.GetKey(sl.IndexOfValue(v))), v);
                        else Console.WriteLine("Такого значения нет...");
                        Console.ReadLine();
                        break;
                    default:
                        l = false;
                        break;
                }
            }
        }
        public static void GetSet(ref SortedList sl)
        {
            bool l = true;
            while (l)
            {
                Console.Clear();
                Console.WriteLine("1 - GetKey\n2 - GetByIndex\n3 - SetByIndex\nЛюбое число - Выйти");
                int code = Convert.ToInt32(Console.ReadLine());
                switch (code)
                {
                    case 1:
                        Console.WriteLine("GetKey\nВведите индекс.");
                        int i = Convert.ToInt32(Console.ReadLine());
                        if (i < sl.Count) Console.WriteLine("Ключ с таким индексом есть...\t{0} - {1}", i, sl.GetKey(i));
                        else Console.WriteLine("Ключа с таким индексом нет...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("GetByIndex\nВведите индекс.");
                        int u = Convert.ToInt32(Console.ReadLine());
                        if (u < sl.Count) Console.WriteLine("Значение с таким индексом есть...\t{0} - {1}", u, sl.GetByIndex(u));
                        else Console.WriteLine("Значения с таким индексом нет...");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("SetByIndex\nВведите индекс.");
                        int z = Convert.ToInt32(Console.ReadLine());
                        if (z < sl.Count)
                        {
                            Console.WriteLine("Введите значение, которое хотите установить по заданному индексу.");
                            string nv = Console.ReadLine();
                            Console.WriteLine("Было...\n{0}: {1}\nСтало...", sl.GetKey(z), sl.GetByIndex(z));
                            sl.SetByIndex(z, nv);
                            Console.WriteLine("{0}: {1}", sl.GetKey(z), sl.GetByIndex(z));
                        }
                        else Console.WriteLine("Такого индекса нет...");
                        Console.ReadLine();
                        break;
                    default:
                        l = false;
                        break;
                }
            }
        }
        public static void Index(ref SortedList sl)
        {
            bool l = true;
            while (l)
            {
                Console.Clear();
                Console.WriteLine("1 - IndexOfKey\n2 - IndexOfValue\nЛюбое число - Выйти");
                int code = Convert.ToInt32(Console.ReadLine());
                switch (code)
                {
                    case 1:
                        Console.WriteLine("IndexOfKey\nВведите ключ.");
                        var k = Console.ReadLine();
                        if (sl.IndexOfKey(k) < 0) Console.WriteLine("Такого ключа нет...");
                        else Console.WriteLine("Индекс данного ключа...\n\t{0}\nЗначение по данному индексу... {1}", sl.IndexOfKey(k), sl.GetByIndex(sl.IndexOfKey(k)));
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("IndexOfValue\nВведите значение.");
                        k = Console.ReadLine();
                        if (sl.IndexOfValue(k) < 0) Console.WriteLine("Такого значения нет...");
                        else Console.WriteLine("Индекс данного значения...\n\t{0}\nКлюч по данному индексу... {1}", sl.IndexOfValue(k), sl.GetKey(sl.IndexOfValue(k)));
                        Console.ReadLine();
                        break;
                    default:
                        l = false;
                        break;
                }
            }
        }
        public static void Clear(ref SortedList sl)
        {
            Console.Clear();
            Console.WriteLine("Clear\n\nБыло...\n\n");
            Show(ref sl);
            sl.Clear();
            Console.WriteLine("\n\nСтало...\n\n");
            Show(ref sl);
        }
        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
