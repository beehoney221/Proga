using System;
namespace raby
{
    class Rab
    {
        public string FIO { get; }
        public string DR { get; }
        public string OB { get; }
        public string GUS { get; }
        public string MR { get; }
        public string GUF { get; }
        public List<string> POLDEL { get; }
        public Rab(string fio, string dr, string ob, List<string> poldel)
        {
            FIO = fio;
            DR = dr;
            OB = ob;
            POLDEL = poldel; 
        }
    }
    class Prikol
    {
        public static void Main()
        {
            List<Rab> people = new List<Rab>();
            string[] lines = { "1 - Заполнениие базы данных", "2 - Поиск по образованию", "3 - Поиск с одной записью", "4 - Поиск по возрасту", "5 - Выход" };
            int code;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                code = Convert.ToInt32(Console.ReadLine());
                switch (code)
                {
                    case 1:people = zap(people); break;
                    case 2: obr(people); break;
                    case 3: zp(people); break;
                    case 4: age(people); break;
                    case 5: vihod(); break;
                }
            }
        }
        public static List<Rab> zap(List<Rab> people)
        {
            Console.Clear();
            while (true)
            {
                string fio, dr, ob;
                Console.Write("Введите ФИО: ");
                fio = Console.ReadLine();
                Console.Write("Введите дату рождения: ");
                dr = Console.ReadLine();
                Console.Write("Введите образование: ");
                ob = Console.ReadLine();
                List<string> poldel = new List<string>();
                while (true)
                {
                    string gus, mr, guf;
                    Console.Write("Введите год устройства на работу: ");
                    gus = Console.ReadLine();
                    Console.Write("Введите место работы: ");
                    mr = Console.ReadLine();
                    Console.Write("Введите год увольнения: ");
                    guf = Console.ReadLine();
                    poldel.Add(gus);
                    poldel.Add(mr);
                    poldel.Add(guf);
                    Console.WriteLine("Введите 'выход', чтобы покинуть ввод работ");
                    Console.WriteLine("или любое другое значение, чтобы остаться");
                    string ex_1 = Console.ReadLine();
                    if (ex_1 == "выход")
                    {
                        break;
                    }
                }

                Rab rab = new Rab(fio, dr, ob, poldel);
                people.Add(rab);
                Console.WriteLine("Введите 'выход', чтобы покинуть ввод пользователей");
                Console.WriteLine("или любое другое значение, чтобы остаться");
                string ex = Console.ReadLine();
                if (ex=="выход")
                {
                    return people;
                    break;
                }
                Console.Clear();
            }
        }
        public static void obr(List<Rab> people)
        {
            Console.Clear();
            bool ok = true;
            Console.WriteLine("Введите уровень образования, по которому нужно найти работников");
            string krit = Console.ReadLine();
            for(int i = 0; i <people.Count; i++)
            {
                if (people[i].OB==krit)
                {
                    ok = false;
                    Console.WriteLine(people[i].FIO);
                }
            }
            if (ok)
            {
                Console.WriteLine("НЕТ ТАКИХ РАБОТНИКОВ!");
            }
            Console.ReadLine();
        }
        public static void zp(List<Rab> people)
        {
            Console.Clear();
            bool ok = true;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].POLDEL.Count == 3)
                {   
                    ok = false; 
                    Console.WriteLine(people[i].FIO);
                }
            }
            if(ok)
            {
                Console.WriteLine("НЕТ ТАКИХ РАБОТНИКОВ!");
            }
            Console.ReadLine();
        }
        public static void age(List<Rab> people)
        {
            Console.Clear();
            bool ok = true;
            Console.WriteLine("Введите год, по которому вы хотите найти рабочих, родившихся в этот год");
            int year_input = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < people.Count; i++)
            {

                string[] kuku = new string[3];
                kuku = (people[i].DR.Split('.'));
                if (Convert.ToInt32(kuku[2]) ==year_input)
                {
                    ok = false;
                    Console.WriteLine(people[i].FIO);
                }
            }
            if (ok)
            {
                Console.WriteLine("НЕТ ТАКИХ РАБОТНИКОВ!");
            }
            Console.ReadLine();
        }
        public static void vihod()
        {
            Environment.Exit(0);
        }
    }
}
