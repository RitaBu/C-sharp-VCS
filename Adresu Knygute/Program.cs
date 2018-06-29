using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdresuKnygute
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"AdresuKnygute.txt";

            var eilutes = File.ReadAllLines(path);
            var zmones = new List<Zmogus>();

            for (int i = 0; i < eilutes.Length; i++)
            {
                if (eilutes[i] != "")
                {
                    var info = eilutes[i].Split(' ');
                    var zmogus = new Zmogus(info[0], info[1], info[2]);
                    zmones.Add(zmogus);
                    Console.WriteLine($"{i + 1}. {zmogus.GrazinkInformacija()}");
                }
            }

            Console.WriteLine("Ivesk nauja knygutes irasa:");

            var naujasIrasas = Console.ReadLine();

            var eiluciuSarasas = eilutes.ToList();
            eiluciuSarasas.Add(naujasIrasas);

            File.WriteAllLines(path, eiluciuSarasas);

            Console.Read();
        }
    }
}
