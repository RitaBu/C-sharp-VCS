using System;

namespace Viktorina
{
    public static class Viktorina
    {
        public static void AtspausdinkKlausimaSuAtsakymais(int klausimoNr, 
                                                           string[] klausimai, string[,] galimiAtsakymai)
        {
            Console.WriteLine(klausimai[klausimoNr]);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1}. {galimiAtsakymai[klausimoNr, i]} ");
            }
        }

        public static int NuskaitykAtsakyma() 
        {
            Console.WriteLine("\nIveskite atsakyma:");
            var atsakymas = int.Parse(Console.ReadLine());
            return atsakymas;
        }
    }
}
