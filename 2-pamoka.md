1. Parašyti programą naudojant `while` ciklą, kuri nuskaitinėja įvestus skaičius tol, kol jų suma nėra daugiau 50.

```c#
int sum = 0;
while(sum < 50) 
{
  int number = int.Parse(Console.ReadLine());
  sum += number;
  Console.WriteLine($"suma: {sum} ");
}
Console.ReadLine();
```

2. Parašyti programą naudojant `while` ciklą, kuri nuskaitinėja paspaustus klavišus ir išveda jų pavadinimus tol, kol nepaspaudžiamas ESC klavišas. 

```c#
while(true) 
{
  var key = Console.ReadKey().Key;
  if(key == ConsoleKey.Escape)
  {
    break;
  } 
  else 
  {
    Console.WriteLine(key.ToString());
  }
}
```

3. Parašyti programą naudojant `for` ciklą, kuri suskaičiuoja pirmų 10 natūraliųjų skaičių sumą.

```c#
int sum = 0;
for (var i = 1; i <= 10; i++)
{
  sum += i;
}
Console.WriteLine("sum: " + sum);
Console.ReadKey();
```

4. Parašyti programą naudojant `for` ciklą, kuri prašo įvesti natūralųjį skaičių ir atspausdina visus žemesnius natūraliuosius skaičius mažėjančia tvarka.

```c#
Console.WriteLine("Iveskite skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

for (var i = skaicius - 1; i > 0; i--) 
{
    Console.WriteLine(i);
}

Console.ReadLine();
```

5. Parašyti programą naudojant for ciklą, kuri prašo įvesti skaičių ir atspausdina jo daugybos lentelę.

```c#
Console.WriteLine("Iveskite skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

for (var i = 1; i <= 10; i++) 
{
    Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
}

Console.ReadLine();
```

6. Parašyti programą naudojant for ciklą, kuri prašo įvesti piramidės aukštį ir atspausdina skaičių piramidę tokiu formatu:

```
1 
2 3 
4 5 6 
7 8 9 10 
```

```c#
Console.Write("Iveskite eiluciu skaiciu: ");
var eiluciuSk = int.Parse(Console.ReadLine());
int isvedamasSkaicius = 1;

//einame per eilutes ir spausdiname skaicius
for (var i = 1; i <= eiluciuSk; i++)
{
    //eiluteje esanciu skaiciu turi buti ne daugiau nei eilutes nr (i)
    for (var j = 1; j <= i; j++)
    {
        Console.Write($"{isvedamasSkaicius} ");
        //kaskarta isvede skaiciu, ji padidiname
        isvedamasSkaicius++;
    }

    Console.Write("\n");
}

Console.ReadLine();
```

7. Parašyti programą, kuri nuskaito 10 elementų į masyvą ir jį atspausdina.

```c#
string[] manoMasyvas = new string[10];

for (var i = 0; i < 10; i++ )
{
    var elementas = Console.ReadLine();
    manoMasyvas[i] = elementas;
}

for (var i = 0; i < 10; i++)
{
    Console.WriteLine(manoMasyvas[i]);
}

Console.ReadLine();
```

8. Parašyti programą, kuri prašo įvesti masyvo dydį ir tada nuskaito n elementų į masyvą ir atspausdina jį atvirkščiai.

```c#
Console.Write("Iveskite masyvo dydi: ");
var masyvoDydis = int.Parse(Console.ReadLine());

string[] manoMasyvas = new string[masyvoDydis];

for(var i = 0; i < masyvoDydis; i++)
{
    var elementas = Console.ReadLine();
    manoMasyvas[i] = elementas;
}

for (var i = masyvoDydis - 1; i >= 0; i--)
{
    Console.WriteLine(manoMasyvas[i]);
}

Console.ReadLine();
```

9. Apibrėžti ir priskirti reikšmes dvimačiam `bool` masyvui, kuris turi 4 eilutes ir 7 stulpelius ir atspausdinti jį ekrane tokiu formatu:

```
---*---
--*-*--
-*-*-*-
*-*-*-*
```
(Jei elemento reikšmė `true` - tai `*`, jei `false`, tai `-`).

```c#
bool[,] manoMasyvas = new bool[4, 7] 
{
    { false, false, false, true, false, false, false },
    { false, false, true, false, true, false, false },
    { false, true, false, true, false, true, false },
    { true, false, true, false, true, false, true}
};

for (int i = 0; i < 4; i++){
    for (int j = 0; j < 7; j++)
    {
        Console.Write($"{(manoMasyvas[i,j] ? "*": "-")}");
    }
    Console.WriteLine();
}

Console.ReadLine();
```
