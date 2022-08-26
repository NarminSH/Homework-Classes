using System;
using System.Reflection;

namespace ClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Instrument guitar = new Guitar("guitar-11", "good");
            Instrument viol = new Violin("viol-11", 3);
            Instrument piano = new Piano("piano-11", "narmin");
            Instrument flute = new Flute("flute-11", 2022);

            Instrument[] elements = {guitar, viol, flute, piano};

            PrintAllInstruments(elements);

            static void PrintAllInstruments(Instrument[] instruments)
            {
                foreach (var instrument in instruments)
                {
                    Console.WriteLine($"Instrument     :  {instrument.GetType().Name}");
                    Console.WriteLine("_________________________________");
                    foreach (PropertyInfo po in instrument.GetType().GetProperties())
                    {
                        Console.WriteLine("Characteristic : ");
                        Console.WriteLine("           ");
                        Console.WriteLine($" PropertName: { po.Name} / PropertyValue {po.GetValue(instrument)}");
                        Console.WriteLine("           ");

                    }

                }
                
            }


        }
    }
}

