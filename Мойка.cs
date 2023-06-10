using System;

namespace Alg
{
    delegate void Washing(Garge cars);
    class Truck
    {
        public string Name { get; set; }
        public string Washing_Ok { get; set; }= " false";
        public Truck (string name, string ok)
        {
            Name = name; 
            Washing_Ok = ok;
        }
    }
    class Garge
    {
        public List<Truck> Trucks { get; set; }
        public Garge(List<Truck> trucks)
        {
            Trucks = trucks;
        }
        
    }
    class Wash
    {
        public void Washing(Garge cars)
        {
            Console.WriteLine("До мойки:");
            Console.WriteLine("\nНомер машины\tМыта ли машина?");
            foreach (var i in cars.Trucks)
            {
                Console.WriteLine(i.Name + "\t" + i.Washing_Ok);
            }
            foreach (var i in cars.Trucks)
            {
                i.Washing_Ok="true";
            }
            Console.WriteLine("После мойки:");
            Console.WriteLine("\nНомер машины\tМыта ли машина?");
            foreach (var i in cars.Trucks)
            {
                Console.WriteLine(i.Name + "\t"+i.Washing_Ok);
            }
        }
    }
    class Programm
    {
        static void Main()
        {
            List<Truck> truks = new List<Truck>();
            truks.Add(new Truck("A256KJ", "false"));
            truks.Add(new Truck("C794BT", "false"));
            truks.Add(new Truck("I524FH", "false"));
            truks.Add(new Truck("T257RT", "false"));
            truks.Add(new Truck("K648EQ", "false"));
            Garge garage = new Garge(truks);
            Wash wash = new Wash();
            Washing washing = wash.Washing;
            washing(garage);
        }
    }
}
