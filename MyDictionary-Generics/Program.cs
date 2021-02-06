using System;

namespace MyDictionary_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(35, "Izmir");
            sehirler.Add(06, "Ankara");
            sehirler.Add(34, "Istanbul");

            sehirler.Add(41, "Kocaeli");
            Console.WriteLine(sehirler.Count);
            sehirler.List();

        }
    }
}
