using System;

namespace ClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Guitar guitar1 = new Guitar("guitar-11", "good");
            Guitar guitar2 = new Guitar("guitar-22", "bad");
            Violin viol1 = new Violin("viol-11", 3);
            Violin viol2 = new Violin("viol-22", 2);
            Piano piano1 = new Piano("piano-11", "narmin");
            Piano piano2 = new Piano("piano-2", "nergiz");
            Flute flute1 = new Flute("flute-11", 2022);
            Flute flute2 = new Flute("flute-22", 2021);

            object[] elements = new object[8] {guitar1, guitar2, viol1,
                                    viol2, flute1, flute2, piano1, piano2};

            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i].ToString());
            }



        }
    }
}

