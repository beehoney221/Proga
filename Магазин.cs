using System;

namespace Alg
{
    class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Product (string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Maker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Maker(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Shop 
    {
        public string Id_Pr { get; set; }
        public string Id_Mk { get; set; }
        public string Data { get; set; }
        public string Volume { get; set; }
        
        public Shop(string id_mk, string id_pr, string data, string volume)
        {
            Id_Pr = id_pr;
            Id_Mk = id_mk;
            Data = data;
            Volume = volume;
        }
    }
    class Shop_Name
    {
        public string Pr { get; set; }
        public string Mk { get; set; }
        public string Data { get; set; }
        public string Volume { get; set; }

        public Shop_Name(string id_pr, string id_mk, string data, string volume)
        {
            Pr = id_pr;
            Mk = id_mk;
            Data = data;
            Volume = volume;
        }
    }
    class Programm
    {
        static void Main()
        {
            List<Maker> maker_table = new List<Maker>();
            maker_table.Add(new Maker("1", "Тюколиночка"));
            maker_table.Add(new Maker("2", "Ермолино"));
            maker_table.Add(new Maker("3", "Сибирские колбасы"));
            maker_table.Add(new Maker("4", "Обжорка"));

            List<Product> product_table = new List<Product>();
            product_table.Add(new Product("1","Пельмени"));
            product_table.Add(new Product("2", "Манты"));
            product_table.Add(new Product("3", "Хинкали"));
            product_table.Add(new Product("4", "Большие пельмени"));
            product_table.Add(new Product("5", "Сибирские пильмени"));
            product_table.Add(new Product("6", "Молоко"));
            product_table.Add(new Product("7", "Ряженка"));
            product_table.Add(new Product("8", "Вкусная колбаса"));

            List<Shop> shop_table = new List<Shop>();
            shop_table.Add(new Shop("1", "6", "05.06.2023", "5 шт"));
            shop_table.Add(new Shop("3", "5", "06.01.2022", "10 шт"));
            shop_table.Add(new Shop("4", "4", "05.06.2023", "20 шт"));
            shop_table.Add(new Shop("2", "1", "06.01.2022", "1500 шт"));
            shop_table.Add(new Shop("2", "2", "15.10.2004", "1 шт"));
            shop_table.Add(new Shop("2", "3", "15.10.2004", "100 шт"));
            shop_table.Add(new Shop("1", "7", "25.05.2023", "200 шт"));
            shop_table.Add(new Shop("3", "8", "26.05.2023", "250 шт"));

            var datePost = from a in product_table
                           from b in maker_table
                           from dad in shop_table
                           where (a.Id ==dad.Id_Pr && b.Id == dad.Id_Mk)
                           group new Shop_Name(a.Name, b.Name, dad.Data, dad.Volume) by dad.Data;
            foreach (var c in datePost)
            {
                Console.WriteLine("Дата поставки: " + c.Key);
                foreach (var cr in c)
                {
                    Console.WriteLine(cr.Pr + "   " + cr.Mk + "   "+cr.Data + "   " + cr.Volume + "   ");
                    
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            var productPost = from a in product_table
                           from b in maker_table
                           from dad in shop_table
                           where (a.Id == dad.Id_Pr && b.Id == dad.Id_Mk)
                           group new Shop_Name(a.Name, b.Name, dad.Data, dad.Volume) by a.Name; 
            Console.WriteLine();
            Console.WriteLine();
            foreach (var c in productPost)
            {
                Console.WriteLine("Название товара: " + c.Key);
                foreach (var cr in c)
                {
                    Console.WriteLine(cr.Pr + "   " + cr.Mk + "   " + cr.Data + "   " + cr.Volume + "   ");

                }
                Console.WriteLine();
                Console.WriteLine();
            }
            var makertPost = from a in product_table
                              from b in maker_table
                              from dad in shop_table
                              where (a.Id == dad.Id_Pr && b.Id == dad.Id_Mk)
                              group new Shop_Name(a.Name, b.Name, dad.Data, dad.Volume) by b.Name;
            Console.WriteLine();
            Console.WriteLine();
            foreach (var c in makertPost)
            {
                Console.WriteLine("Название производителя: " + c.Key);
                foreach (var cr in c)
                {
                    Console.WriteLine(cr.Pr + "   " + cr.Mk + "   " + cr.Data + "   " + cr.Volume + "   ");

                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
        }
}
