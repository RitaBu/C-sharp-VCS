
1. Parašyti programą, kuri nuskaito įvestą tekstą ir atspausdina jį ekrane. Atspausdintus duomenis rodyti, kol nepaspaudžiamas ENTER. 

```c#
Console.WriteLine("Iveskite teksta:");
var tekstas = Console.ReadLine();
Console.WriteLine(tekstas);
Console.ReadLine();
```

2. Parašyti programą, kuri ATSKIRAI prašo įvesti vardą, pavardę, amžių ir atspausdina juos ekrane. Naudoti kintamuosius.

```c#
Console.WriteLine("Iveskite varda:");
var vardas = Console.ReadLine();


Console.WriteLine("Iveskite pavarde:");
var pavarde = Console.ReadLine();


Console.WriteLine("Iveskite amziu:");
var amzius = Console.ReadLine();

Console.WriteLine($"{vardas} {pavarde} {amzius}");
Console.ReadLine();
```
Parašyti programą, kuri prašo įvesti apskritimo spindulį ir pagal jį suskaičiuoja jo ilgį ir plotą.

```c#
Console.WriteLine("Iveskite apskritimo spinduli:");
var spindulysTekstas = Console.ReadLine();
var spindulys = int.Parse(spindulysTekstas);

var ilgis = 2 * Math.PI * spindulys;
var plotas = Math.PI * Math.Pow(spindulys, 2);

Console.WriteLine("Apskritimo ilgis: " + ilgis);
Console.WriteLine("Apskritimo plotas: " + plotas);

Console.ReadLine();
```
