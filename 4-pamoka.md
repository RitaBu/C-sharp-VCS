1. Parašykite programą, kuri nuskaito įvesta sakinį ir kiekviena sakinio žodį atspausdina atskiroje eilutėje.

```c#
Console.WriteLine("Iveskite sakini:");

var sakinys = Console.ReadLine();
var sakinioZodziai = sakinys.Split(' ');

foreach (var zodis in sakinioZodziai)
{
    Console.WriteLine(zodis);
}

Console.Read();
```

2. Parašykite programą, kuri nuskaito įvesta eilutę ir išveda ja tarp kiekvieno simbolio idėjus tarpą atvirkščiai, pvz.:l o o h c s g n i d o c s u i n l i v

```c#
Console.WriteLine("Iveskite sakini:");

var sakinys = Console.ReadLine();

var atvirksciasSakinysSuTarpais = "";

for (int i = sakinys.Length - 1; i >= 0; i--)
{
    atvirksciasSakinysSuTarpais += sakinys[i] 
        + (sakinys[i] != ' ' ? " " : String.Empty); 
    //jeigu ne tarpas, tai pridedam tarpa, kitu atveju - tuscia stringa
}

Console.WriteLine(atvirksciasSakinysSuTarpais);
Console.Read();
```

3. Parašykite programą, kuri nuskaito sakinį, tada pirmą žodį, antrą žodį ir sakinyje, jei yra pirmas žodis, pakeičia jį antru.

```c#
Console.WriteLine("Iveskite sakini:");
var sakinys = Console.ReadLine();

Console.WriteLine("Iveskite pirma zodi:");
var zodis1 = Console.ReadLine();

Console.WriteLine("Iveskite antra zodi:");
var zodis2 = Console.ReadLine();

if(sakinys.Contains(zodis1)) {
    sakinys = sakinys.Replace(zodis1, zodis2);
}

Console.WriteLine(sakinys);
Console.Read();
```

4. Parašykite programą, kuri paprašo įvesti sakinį su žodžiu nemoku, randa jį sakinyje, iškerpa ir gražina sakinį be jo. Panaudokite `IndexOf` ir `Substring` f-jas.

```c#
Console.WriteLine("Iveskite sakini:");
var sakinys = Console.ReadLine();

var nemoku = "nemoku";

var i = sakinys.IndexOf(nemoku);

if(i > -1) 
{
    var start = i + nemoku.Length + 1;
    var end = sakinys.Length - (i + nemoku.Length + 1);

    sakinys = sakinys.Substring(0, i - 1) + " "
                     + sakinys.Substring(start, end);
}

Console.WriteLine(sakinys);
Console.Read();
```

5. Patobulinkite kalkuliatoriaus programą, kad būtų galima įvesti matematinį veiksmą vienoje eilutėje atskirtą tarpais, pvz.: “2 + 5”,  “12 / 4”

```c#
Console.WriteLine("Iveskite matematini veiksma: ");
string eilute = Console.ReadLine();

var demenys = eilute.Split(' ');

int skaicius1 = int.Parse(demenys[0]);
string operacija = demenys[1];
int skaicius2 = int.Parse(demenys[2]);

switch (operacija)
{
    case "+":
        Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
        break;
    case "-":
        Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
        break;
    case "*":
        Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
        break;
    case "/":
        Console.WriteLine($"{skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");
        break;
    case "%":
        Console.WriteLine($"{skaicius1} % {skaicius2} = {skaicius1 % skaicius2}");
        break;
    case "^":
        Console.WriteLine($"{skaicius1} ^ {skaicius2} = {Math.Pow(skaicius1, skaicius2)}");
        break;
    default:
        Console.WriteLine("Nesuprantu tokios operacijos.");
        break;
}

Console.ReadLine();
```

6. Parašykite programą, kuri nuskaito sakinį ir išveda žodžius atvirkštinetvarka vienoje eiluėje, pašalina skyrybos ženklus ir visas raides paverčia didžiosiomis, pvz.: Labas, kaip sekasi? => SEKASI KAIP LABAS

```c#
```

7. Sukurkite failą su tekstu. Nuskaitykite jį ir išveskite į Console.

```c#
```

8. Sukurkite failą su tekstu. Nuskaitykite tekstą, kas antro žodžio raides paverskite didžiosiomis ir įrašykite į failą.

```c#
```

9. Parašykite programą, kaip ir pavyzdyje skaidrėse, kuri nuskaito du skaičius, padalina vieną iš kito ir grąžina rezultatą. 
*Programa turi nenulūžti, jei netyčia įves raidę, o išvesti klaidos pranešimą, kad įvesti duomenys yra neteisingi. 
*Dalybos iš nulio atveju, programa irgi turi nenulūžti, o turi išvesti klaidos pranešimą, kad dalyba iš nulio yra negalima.

```c#
```
