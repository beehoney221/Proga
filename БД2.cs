using Microsoft.VisualBasic.FileIO;
using System;
namespace raby
{
    class father
    {
        protected string NAME;
        protected string NUMBER;
        protected List<string> LS;
        public string RETNAME() { return NAME; }
        public string RETNUMBER() { return NUMBER; }
        public List<string> RETLS() { return LS; }
    }
    class KING:father
    {
        private string DOLG;
        public KING(string name, string num, string dolg, List<string> poldel)
        {
            NAME = name;
            NUMBER = num;
            DOLG = dolg;
            LS = poldel;
        }
    }
    class DRIVER: father
    {
        private string DOLG;
        private List<string> TRANS;
        public DRIVER(string name,string num, string dolg, List<string> poldel, List<string> trans)
        {
            NAME = name;
            NUMBER = num;
            DOLG = dolg;
            LS = poldel;
            TRANS = trans;
        }
        public List<string> RETTRANS() { return TRANS; }
    }
    class HELP_PEOPLE : father
    {
        private string DOLG;
        private List<string> FIX;
        public HELP_PEOPLE(string name,string num, string dolg, List<string> poldel, List<string> fix)
        {
            NAME = name;
            NUMBER = num;
            DOLG = dolg;
            LS = poldel;
            FIX = fix;
        }
    }
    class BIBIKI : father
    {
        private List<string> TO;
        private List<string> VOD;
        public BIBIKI(string tip, string num, List<string> rem, List<string> to, List<string> vod)
        {
            NAME = tip;
            NUMBER = num;
            LS = rem;
            TO = to;
            VOD = vod;
        }
        public List<string> RETTO() { return TO; }
        public List<string> RETVOD() { return VOD; }
    }
    class DIRECT : father 
    {
        public DIRECT(string name, string num, List<string> poldel)
        {
            NAME = name;
            NUMBER = num;
            LS = poldel;
        }
    }
    class Prikol
    {
        public static void Main()
        {
            List<KING> king = new();
            List<DRIVER> driver = new();
            List<HELP_PEOPLE> help_people = new();
            List<BIBIKI> bibiki = new();
            List<DIRECT> direct = new();
            string[] lines = { "1 - Заполнениие базы данных", "2 - Поиск техосмотра", "3 - Поиск водителей по номеру машины", "4 - Поиск машин, которые водил водитель", "5 - Определение стажа", "6 - Поиск приказов", "7 - Выход" };
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
                    case 1: zap(ref king, ref driver, ref help_people, ref bibiki, ref direct); break;
                    case 2: to(bibiki); break;
                    case 3: vodit(bibiki); break;
                    case 4: vodit_trans(driver); break;
                    case 5: exp(king, help_people, driver); break;
                    case 6: sur_order(direct); break;
                    case 7: vihod(); break;
                }
            }

        }
        public static void zap(ref List<KING> king, ref List<DRIVER> driver, ref List<HELP_PEOPLE> help_people, ref List<BIBIKI> bibiki, ref List<DIRECT> direct)
        {
            Console.Clear();
            string[] lines = { "1 - Ввод работников", "2 - Ввод машин", "3 - Ввод приказов", "4 -- Выход" };
            int code;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                code = Convert.ToInt32(Console.ReadLine());
                if (code == 1)
                {
                    while (true)
                    {
                        string fio, dol, dr;
                        Console.Write("Введите ФИО: ");
                        fio = Console.ReadLine();
                        Console.Write("Введите дату рождения: ");
                        dr = Console.ReadLine();
                        Console.Write("Введите должность: ");
                        dol = Console.ReadLine();
                        List<string> poldel = new List<string>();
                        List<string> auto_rem = new List<string>();
                        List<string> auto_to_h = new List<string>();
                        List<string> num_trans = new List<string>();
                        while (true)
                        {
                            string gus, mr, guf;
                            Console.Write("Введите дату устройства на работу: ");
                            gus = Console.ReadLine();
                            Console.Write("Введите место работы: ");
                            mr = Console.ReadLine();
                            Console.Write("Введите дату увольнения: ");
                            guf = Console.ReadLine();
                            poldel.Add(gus);
                            poldel.Add(mr);
                            poldel.Add(guf);
                            Console.WriteLine("Введите 'выход', чтобы покинуть ввод работ ");
                            Console.WriteLine("или любое другое значение, чтобы остаться");
                            string ex_1 = Console.ReadLine();
                            if (ex_1 == "выход")
                            {
                                break;
                            }
                        }
                        if (dol == "водитель")
                        {
                            while (true)
                            {
                                string prikol;
                                Console.Write("Введите номер машины: ");
                                prikol = Console.ReadLine();
                                num_trans.Add(prikol);
                                Console.WriteLine("Введите 'выход', чтобы покинуть ввод машин, которыми управлял водитель");
                                Console.WriteLine("или любое другое значение, чтобы остаться");
                                string ex_1 = Console.ReadLine();
                                if (ex_1 == "выход")
                                {
                                    break;
                                }
                            }
                            DRIVER human = new DRIVER(fio, dr, dol, poldel, num_trans);
                            driver.Add(human);
                            Console.ReadLine();
                        }
                        if (dol == "управляющий")
                        {
                            KING human = new KING(fio, dr, dol, poldel);
                            king.Add(human);
                        }
                        if (dol == "автослесарь")
                        {
                            while (true)
                            {
                                string prikol;
                                Console.Write("Введите номер машины, которую ремонтировал работник: ");
                                prikol = Console.ReadLine();
                                auto_rem.Add(prikol);
                                Console.WriteLine("Введите 'выход', чтобы покинуть ввод ремонтированных машин");
                                Console.WriteLine("или любое другое значение, чтобы остаться");
                                string ex_1 = Console.ReadLine();
                                if (ex_1 == "выход")
                                {
                                    break;
                                }
                            }
                            HELP_PEOPLE hp = new HELP_PEOPLE(fio, dr, dol, poldel, auto_rem);
                            help_people.Add(hp);
                        }
                        if (dol == "уборщик")
                        {
                            HELP_PEOPLE hp = new HELP_PEOPLE(fio, dr, dol, poldel, auto_rem);
                            help_people.Add(hp);
                        }
                        Console.WriteLine("Введите 'выход', чтобы покинуть ввод работников ");
                        Console.WriteLine("или любое другое значение, чтобы остаться");
                        string ex_78 = Console.ReadLine();
                        if (ex_78 == "выход")
                        {
                            break;
                        }
                    }
                }
                if (code == 2)
                {
                    while (true)
                    {
                        string fio, dol;
                        Console.Write("Введите тип машины: ");
                        fio = Console.ReadLine();
                        Console.Write("Введите номер машины: ");
                        dol = Console.ReadLine();
                        List<string> name_trans = new List<string>();
                        List<string> auto_rem = new List<string>();
                        List<string> auto_to = new List<string>();
                        while (true)
                        {
                            string prikol;
                            Console.Write("Введите имя водителя машины: ");
                            prikol = Console.ReadLine();
                            name_trans.Add(prikol);
                            Console.WriteLine("Введите 'выход', чтобы покинуть ввод водителей данной машины");
                            Console.WriteLine("или любое другое значение, чтобы остаться");
                            string ex_2 = Console.ReadLine();
                            if (ex_2 == "выход")
                            {
                                break;
                            }
                        }
                        while (true)
                        {
                            string prikol;
                            Console.Write("Введите дату прохождения техосмотра: ");
                            prikol = Console.ReadLine();
                            auto_to.Add(prikol);
                            Console.WriteLine("Введите 'выход', чтобы покинуть ввод информации о техосмотрах");
                            Console.WriteLine("или любое другое значение, чтобы остаться");
                            string ex_2 = Console.ReadLine();
                            if (ex_2 == "выход")
                            {
                                break;
                            }
                        }
                        while (true)
                        {
                            string prikol;
                            Console.Write("Введите дату ремонта: ");
                            prikol = Console.ReadLine();
                            auto_rem.Add(prikol);
                            Console.WriteLine("Введите 'выход', чтобы покинуть ввод информации о ремонте");
                            Console.WriteLine("или любое другое значение, чтобы остаться");
                            string ex_2 = Console.ReadLine();
                            if (ex_2 == "выход")
                            {
                                break;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Введите 'выход', чтобы покинуть ввод машин");
                        Console.WriteLine("или любое другое значение, чтобы остаться");
                        string ex_1 = Console.ReadLine();
                        if (ex_1 == "выход")
                        {
                            break;
                        }
                        BIBIKI hp = new BIBIKI(fio, dol, auto_rem, auto_to, name_trans);
                        bibiki.Add(hp);
                    }
                }
                if (code == 3)
                {
                    while (true)
                    {
                        string fio, dol;
                        Console.Write("Введите наименование приказа: ");
                        fio = Console.ReadLine();
                        Console.Write("Введите дату вступления в силу: ");
                        dol = Console.ReadLine();
                        List<string> upr_sos = new List<string>();
                        Console.Write("Введите имя управляющего, подписавшего приказ ");
                        string prikol = Console.ReadLine();
                        upr_sos.Add(prikol);
                        DIRECT dIRECT = new DIRECT(fio, dol, upr_sos);
                        direct.Add(dIRECT);                        
                        Console.WriteLine("Введите 'выход', чтобы покинуть ввод приказов");
                        Console.WriteLine("или любое другое значение, чтобы остаться");
                        string ex_2 = Console.ReadLine();
                        if (ex_2 == "выход")
                        {
                            break;
                        }

                    }
                }
                if (code == 4)
                {
                    break;
                }
            }
        }
        public static void vodit(List<BIBIKI> bibiki)
        {
            Console.Clear();
            Console.WriteLine("Введите номер машины: ");
            string nom = Console.ReadLine();
            foreach (BIBIKI i in bibiki)
            {
                if (i.RETNAME() == nom)
                {
                    foreach (string j in i.RETVOD())
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
        public static void to(List<BIBIKI> bibiki)
        {
            Console.Clear();
            Console.WriteLine("Введите номер машины: ");
            string nom = Console.ReadLine();
            foreach (BIBIKI i in bibiki)
            {
                if (i.RETNAME() == nom)
                {
                    foreach (string j in i.RETTO())
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
        public static void vodit_trans(List<DRIVER> driver)
        {
            Console.Clear();
            Console.WriteLine("Введите имя водителя: ");
            string nom = Console.ReadLine();
            foreach (DRIVER i in driver)
            {
                if (i.RETNAME() == nom)
                {
                    foreach (string j in i.RETTRANS())
                    {
                        Console.WriteLine(j);
                    }
                }
                Console.ReadLine();
            }
        }
        public static void sur_order(List<DIRECT> direct)
        {
            Console.Clear();
            Console.Write("Введите название приказа: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Кем подписан...");
            foreach (DIRECT i in direct)
            {
                if (i.RETNAME() == nom)
                {
                    foreach (string j in i.RETLS())
                    {
                        Console.WriteLine(j);
                    }
                    Console.WriteLine("Дата подписания:", i.RETNUMBER());
                }
            }
        }
        public static void exp(List<KING> king, List<HELP_PEOPLE> help_people, List<DRIVER> driver)
        {
            Console.Clear();
            Console.Write("Введите имя работника: ");
            string name = Console.ReadLine();
            Console.Write("Введите должность работника: ");
            string jt = Console.ReadLine();
            int exper = 0;
            int exper_l = 0;
            if (jt == "управляющий")
            {
                exper = 0;
                exper_l = 0;
                foreach (KING i in king)
                {
                    if (i.RETNAME() == name)
                    {
                        int one = 0;
                        int two = 0;
                        for (int j = 0; j < i.RETLS().Count() - 2; j += 3)
                        {
                            one = Convert.ToInt32(i.RETLS()[j].Substring(5));
                            if (i.RETLS()[j+2] != "-")
                            {
                                two = Convert.ToInt32(i.RETLS()[j + 2].Substring(5));
                                exper += (two - one);
                            }
                            else
                            {
                                exper += (2023 - one);
                                exper_l += (2023 - one);
                            }
                        }
                    }
                }
            }
            else if (jt == "водитель")
            {
                exper = 0;
                exper_l = 0;
                foreach (DRIVER i in driver)
                {
                    if (i.RETNAME() == name)
                    {
                        int one = 0;
                        int two = 0;
                        for (int j = 0; j < i.RETLS().Count() - 2; j += 3)
                        {
                            one = Convert.ToInt32(i.RETLS()[j].Substring(5));
                            if (i.RETLS()[j + 2] != "-")
                            {
                                two = Convert.ToInt32(i.RETLS()[j + 2].Substring(5));
                                exper += (two - one);
                            }
                            else
                            {
                                exper += (2023 - one);
                                exper_l += (2023 - one);
                            }
                        }
                    }
                }
            }
            else
            {
                exper = 0;
                exper_l = 0;
                foreach (HELP_PEOPLE i in help_people)
                {
                    if (i.RETNAME() == name)
                    {
                        int one = 0;
                        int two = 0;
                        for (int j = 0; j < i.RETLS().Count() - 2; j += 3)
                        {
                            one = Convert.ToInt32(i.RETLS()[j].Substring(5));
                            if (i.RETLS()[j + 2] != "-")
                            {
                                two = Convert.ToInt32(i.RETLS()[j + 2].Substring(5));
                                exper += (two - one);
                            }
                            else
                            {
                                exper += (2023 - one);
                                exper_l += (2023 - one);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Текущий стаж: " + exper_l + "\nОбщий стаж: " + exper);
        }
        public static void vihod()
        {
            Environment.Exit(0);
        }
    }
}
