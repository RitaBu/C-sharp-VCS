```C#
class Program
    {
        static void Main(string[] args)
        {
            const int klausimuSk = 3;
            const int atsakymuSk = 3;

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
                Console.WriteLine(klausimai[i]);

                for (int j = 0; j < atsakymuSk; j++)
                {
                    Console.Write($"{j+1}. {galimiAtsakymai[i, j]} ");
                }

                Console.WriteLine("\nIveskite atsakyma:");

                var atsakymas = int.Parse(Console.ReadLine());

                if(atsakymas == teisingiAtsakymai[i])
                {
                    taskai += 3;
                }
                else 
                {
                    Console.WriteLine("Atsakymas neteisingas! Bandykite dar karta:");

                    var antrasAtsakymas = int.Parse(Console.ReadLine());
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
```
