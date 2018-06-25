
1. Parašyti programą, kuri nuskaito įvestą skaičių ir patikrina ar jis yra lyginis ar nelyginis.

```c#
Console.WriteLine("Iveskite naturaluji skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

var lyginis = skaicius % 2 == 0;

if(lyginis)
{
    Console.WriteLine("Skaicius yra lyginis.");
}
else 
{
    Console.WriteLine("Skaicius yra nelyginis.");
}
```
galima ir šitaip, išnaudojant [trinarį operatorių](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator):

```c#
Console.WriteLine("Iveskite naturaluji skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

Console.WriteLine($"Skaicius yra { (skaicius % 2 == 0 ? "lyginis" : "nelyginis") } ");

Console.ReadLine();
```

2. Parašyti programą, kuri nuskaito savaitės dienos numerį ir atspausdina jos žodinį pavadinimą ekrane.

```c#
Console.WriteLine("Iveskite savaites dienos numeri: ");
int savDienosNr = int.Parse(Console.ReadLine());

switch(savDienosNr){
    case 1:
        Console.WriteLine("Pirmadienis");
        break;
    case 2:
        Console.WriteLine("Antradienis");
        break;
    case 3:
        Console.WriteLine("Treciadienis");
        break;
    case 4:
        Console.WriteLine("Ketvirtadienis");
        break;
    case 5:
        Console.WriteLine("Penktadienis");
        break;
    case 6:
        Console.WriteLine("Sestadienis");
        break;
    case 7:
        Console.WriteLine("Sekmadienis");
        break;
    default:
        Console.WriteLine("Savaiteje yra tik septynios dienos!!!");
        break;
}

Console.ReadLine();
```

3. Parašyti programą kalkuliatorių, kuri nuskaito 2 skaičius, nuskaito matematinį veiksmą, atlieka veiksmą ir atspausdina rezultatą ekrane tokiu formatu:
```c# 
{pirmas skaicius} {matematinis veiksmas} {antras skaičius} = {rezultatas}
```

```c# 
Console.WriteLine("Iveskite pirma skaiciu: ");
int skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite operacija:");
string operacija = Console.ReadLine();

Console.WriteLine("Iveskite antra skaiciu:");
int skaicius2 = int.Parse(Console.ReadLine());

switch(operacija){
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

galima ir taip, bet VS turėtų siūlyti paversti į `switch`:

```c# 
Console.WriteLine("Iveskite pirma skaiciu: ");
int skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite operacija:");
string operacija = Console.ReadLine();

Console.WriteLine("Iveskite antra skaiciu:");
int skaicius2 = int.Parse(Console.ReadLine());

double rezultatas = 0;

if(operacija == "+") 
{
    rezultatas = skaicius1 + skaicius2;
}
else if(operacija == "-") 
{
    rezultatas = skaicius1 - skaicius2;
}
else if (operacija == "*")
{
    rezultatas = skaicius1 * skaicius2;
}
else if (operacija == "/")
{
    rezultatas = skaicius1 / skaicius2;
}
else if (operacija == "%")
{
    rezultatas = skaicius1 % skaicius2;
}
else if (operacija == "^")
{
    rezultatas = Math.Pow(skaicius1, skaicius2);
}

Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {rezultatas}");

Console.ReadLine();
```

