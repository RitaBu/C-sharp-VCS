using System;

namespace Viktorina
{
    class Program
    {
        static void Main(string[] args)
        {
            const int klausimuSk = 3;

            int taskai = 0;

            string[] klausimai = {
                "Kokia Vengrijos sostine?",
                "Kokios grupes albumas vadinas \"Dark side of the moon\"?",
                "Kas parase romana \"Vargdieniai\"?"
            };

            string[,] galimiAtsakymai = {
                {"Atenai", "Budapestas", "Praha"},
                {"Led Zeppelin", "ABBA", "Pink Floyd"},
                {"V. Hugo", "L. Tolstojus", "F. Dostojevskis"}
            };

            int[] teisingiAtsakymai = { 2, 3, 1 };

            for (int i = 0; i < klausimuSk; i++)
            {
                Viktorina.AtspausdinkKlausimaSuAtsakymais(i, klausimai, galimiAtsakymai);
                var atsakymas = Viktorina.NuskaitykAtsakyma();

                if (atsakymas == teisingiAtsakymai[i])
                {
                    taskai += 3;
                }
                else
                {
                    var antrasAtsakymas = Viktorina.NuskaitykAtsakyma();
                    if (antrasAtsakymas == teisingiAtsakymai[i])
                    {
                        taskai++;
                    }
                }
            }

            Console.WriteLine($"Is viso surinkote tasku: {taskai}");

            Console.Read();
        }
    }
}
