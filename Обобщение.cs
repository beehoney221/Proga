using System;
namespace OBOB
{
    class Ob<T>
    {
        public List<T> Massiv;
        public Ob(List<T> massiv)
        {
            this.Massiv = massiv;
        }
        public void Append(T prikol )
        {
            Massiv.Add( prikol );
        }
        public T Found(int i)
        {
            return Massiv[i];
        }  
        public void Deleted(T prikol )
        {
            Massiv.Remove( prikol );
        }
        
    }
    class Programm
    {
        static void Main()
        {
            List<object> spisok = new List<object>();
            Ob<object> spisok_spisok = new Ob<object>(spisok);
            spisok_spisok.Append(1326);
            spisok_spisok.Append(1325);
            spisok_spisok.Append(true && false);
            spisok_spisok.Append(128.21);
            spisok_spisok.Append("Строка");
            spisok_spisok.Append('c');
            foreach (object obj in spisok)
            {
                Console.WriteLine(obj.ToString());
                
            }
            spisok_spisok.Deleted(1325);
            Console.WriteLine("После удаления 1325");
            foreach (object obj in spisok)
            {
                Console.WriteLine(obj.ToString());

            }
            Console.WriteLine();
            object objj = spisok_spisok.Found(1);
            Console.WriteLine(objj.ToString());
        }
    }
}
