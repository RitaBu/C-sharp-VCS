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

            Console.WriteLine();
        }

        public static int NuskaitykAtsakyma() 
        {
            bool ivedeTesingai = false;

            while(!ivedeTesingai)
            {
                try
                {
                    Console.WriteLine("Iveskite atsakyma:");
                    var atsakymas = int.Parse(Console.ReadLine());
                    ivedeTesingai = true;
                    return atsakymas;
                }
                catch (Exception)
                {
                    Console.WriteLine("Neteisingu formatu ivestas atskaymas. Bandykite dar karta");
                } 
            }

            return 0;
        }
    }
}
