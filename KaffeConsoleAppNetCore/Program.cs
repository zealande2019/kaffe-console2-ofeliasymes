using kaffe;
using System;
using System.Collections.Generic;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FlatWhite newFlatwhite = new FlatWhite(10);
            Console.WriteLine(newFlatwhite.Pris());
            Console.WriteLine(newFlatwhite.Styrke());
            Console.WriteLine(newFlatwhite.MlMælk());
            Console.WriteLine(newFlatwhite.Rabat);
            Console.ReadKey();

            Cortado cortado = new Cortado();
            Latte latte = new Latte();
            FlatWhite flatWhite = new FlatWhite(12);

            List<Imælk> liste = new List<Imælk>();
            liste.Add(cortado);
            liste.Add(latte);

            foreach (var item in liste)
            {
                Console.WriteLine("Før cast " + item.MlMælk());

                if (item is Latte)
                {
                    latte = item as Latte;
                    Console.WriteLine("Latte styrke" + latte.Styrke());
                }
                else if (item is Cortado)
                {
                    Cortado c = item as Cortado;
                }
            }
            
        }
    }
}
