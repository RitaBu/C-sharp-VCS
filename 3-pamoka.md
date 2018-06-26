1. Parašykite metodą `Pasisveikink`.

```c#
class Program
{
    static void Main(string[] args)
    {
        Pasisveikink("Labas");
        Console.Read();
    }

    public static void Pasisveikink(string pasveikinimoTekstas)
    {
        Console.WriteLine(pasveikinimoTekstas);
    }
}
```

2. Parašyti metodą, kuris prašo įvesti du skaičius ir apkeičia juos vietomis. Pvz.: input – 2,3 result – „Pirmas skaičius yra 3, antras skaičius yra 2“.

```c#
class Program
{
    static void Main(string[] args)
    {
        //metodas yra void ir atspausdina pats
        ApkeiskVietomis1(10, 8);

        //metodas grazina string'a, kuri turim atspausdinti patys
        var tekstas = ApkeiskVietomis2(10, 8);
        Console.WriteLine(tekstas);

        Console.Read();
    }

    //Galima dviem budais:
    public static void ApkeiskVietomis1(int sk1, int sk2)
    {
        Console.WriteLine($"Pirmas skaicius yra {sk1}, o antras - {sk2}");
    }

    public static string ApkeiskVietomis2(int sk1, int sk2)
    {
        return $"Pirmas skaicius yra {sk1}, o antras - {sk2}";
    }
}
```

3. Parašyti metodą, kuris suskaičiuoja žmogaus kūno masės indeksą. Formulė svoris kg / (ūgis metrais) ^ 2).

```c#
class Program
{
    static void Main(string[] args)
    {
        const double ugis = 1.78;
        const double svoris = 200;

        var kmi = KMI(ugis, svoris);

        Console.Read();
    }

    public static double KMI(double ugisMetrais, double svorisKg)
    {
        return svorisKg / ugisMetrais * ugisMetrais;
    }
}
```
4. Papildyti 3-io pratimo programą parašant metodą, kuris pagal gautą KMI nustato žmogaus fizinę būseną (Šis metodas savyje turi iškviesti KMI skaičiuojantį metodą)

```c#
class Program
{
    static void Main(string[] args)
    {
        const double ugis = 1.78;
        const double svoris = 200;

        NustatykFizineBukle(ugis, svoris);

        Console.Read();
    }

    public static void NustatykFizineBukle(double ugisMetrais, double svorisKg) 
    {
        var kmi = KMI(ugisMetrais, svorisKg);
        if(kmi < 15) 
        {
            Console.WriteLine("Badaujantis žmogus");
        }
        else if(kmi < 18.5) {
            Console.WriteLine("Liesas žmogus");
        }
        else if (kmi < 25)
        {
            Console.WriteLine("Normalaus svorio žmogus");
        }
        else if (kmi < 30)
        {
            Console.WriteLine("Turintis viršsvorio žmogus");
        }
        else if (kmi < 40)
        {
            Console.WriteLine("Nutukęs žmogus");
        }
        else
        {
            Console.WriteLine("Ligotai nutukęs žmogus");
        }
    }

    public static double KMI(double ugisMetrais, double svorisKg)
    {
        return svorisKg / ugisMetrais * ugisMetrais;
    }
}
```

5. Parašykite metodą, kuris atspausdina gautą masyvą į vieną eilutę su tarpais

```c#
class Program
{
    static void Main(string[] args)
    {
        int[] manoMasyvas = { 1, 3, 6, 8, 9, 10 };
        AtspausdinkMasyva(manoMasyvas);
        Console.Read();
    }

    public static void AtspausdinkMasyva(int[] masyvas)
    {
        foreach(var elementas in masyvas)
        {
            Console.Write($"{elementas} ");
        }
        Console.WriteLine();
    }
}
```
6. Parašykite metodą Max, kuris priima skaičių masyvą ir grąžiną didžiausią skaičių.
```c#
class Program
{
    static void Main(string[] args)
    {
        int[] manoMasyvas = { 1, 3, 6, 8, 9, 10 };

        var max = Max(manoMasyvas);

        Console.WriteLine(max);

        Console.Read();
    }

    public static int Max(int[] masyvas)
    {
        int max = 0;

        foreach(var skaicius in masyvas) 
        {
            if(skaicius > max)
            {
                max = skaicius;
            }
        }
        return max;
    }
}
```
7. Parašyti metodą, kuris atspausdina, kokia dabar savaitės diena ir suskaičiuoja už kiek dienų bus penktadienis. Rezultato pvz.: „Today is Thursday, Friday is in 1 day“.
```c#
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(KiekDienuLikoIkiPenktadienio());
        Console.Read();
    }

    public static int KiekDienuLikoIkiPenktadienio()
    {
        var siandienData = DateTime.Now;
        var siandienosSavDienosNr = (int)siandienData.DayOfWeek;

        if(siandienosSavDienosNr <= 5)
        {
            return 5 - siandienosSavDienosNr;
        }
        else 
        {
            return (7 - siandienosSavDienosNr) + 5;
        }
    }
}
```
8. Susikurti List‘ą iš 10 elementų:
* Panaudoti kiekvieną metodą paminėtą praeitoje skaidrėje
* Apsirašyti atskirą metodą - SpausdintiSarasa, kuris atspausdins sąrašą su foreach
* Po kiekvieno metodo atspausdinti visą sąrašą panaudojant SpausdintiSarasa

```c#
class Program
{
    static void Main(string[] args)
    {
        List<string> manoSarasas = new List<string> { "Labas,", "as", "krabas!", "kas", "esi", "tu" };
        SpausdintiSarasa(manoSarasas);

        manoSarasas.Add("?!");
        SpausdintiSarasa(manoSarasas);

        manoSarasas.Remove("tu");
        SpausdintiSarasa(manoSarasas);

        manoSarasas.Sort();
        SpausdintiSarasa(manoSarasas);

        Console.Read();
    }

    public static void SpausdintiSarasa(List<string> sarasas)
    {
        foreach(var elementas in sarasas)
        {
            Console.Write($"{elementas} ");
        }
        Console.WriteLine();
    }
}
```
9. Susikurti int List’ą:
* Nuskaityti iš konsolės n įvestų vaiko pažymių
* Suskaičiuoti pažymių vidurkį
* Suskaičiuoti pažymių medianą
* Išveskite lentelę su kiekvieno pažymio statistika, kiek kokių pažymių yra
* Skaičiavimams susikurkite atskirus metodus


```c#
class Program
{
    static void Main(string[] args)
    {
        List<int> pazymiai = new List<int>();
        NuskaitykPazymius(pazymiai);
        IsveskVidurki(pazymiai);
        SuskaiciuokMediana(pazymiai);
        //IsveskPazymiuStatistika(pazymiai);
        Console.Read();
    }

    private static void NuskaitykPazymius(List<int> pazymiai)
    {
        while(true)
        {
            var eilute = Console.ReadLine();

            if (eilute != "")
            {
                pazymiai.Add(int.Parse(eilute));
            }
            else break;
        }
    }

    private static void IsveskVidurki(List<int> pazymiai)
    {
        var vidurkis = pazymiai.Sum() / (pazymiai.Count*1.00); 
        //dauginame is double skaiciaus - 1.00, kad negrazintu vidurkio int,
        //nes sum grazina int ir count grazina int, tada automatiskai / grazina int
        Console.WriteLine($"vidurkis: {vidurkis}");
    }

    private static void SuskaiciuokMediana(List<int> pazymiai)
    {
        double mediana = 0;

        pazymiai.Sort();

        if (pazymiai.Count % 2 == 0)
        {
            var vidurinisSk1 = pazymiai.Count / 2;
            var vidurinisSk2 = pazymiai.Count / 2 + 1;
            mediana = (vidurinisSk1 + vidurinisSk2)*1.0 / 2;
        }
        else
        {
            mediana = pazymiai.Count / 2 + 1;
        }
        Console.WriteLine($"mediana: {mediana}");
    }

    private static void IsveskPazymiuStatistika(List<int> pazymiai)
    {
        for (var i = 1; i <= 10; i++)
        {
            var pazymioSk = 0;

            foreach(var pazymis in pazymiai)
            {
                if (pazymis == i) pazymioSk++;
            }

            Console.WriteLine($"{i}-u yra: {pazymioSk}");
        }
    }
}
```
