dokumentacija: https://msdn.microsoft.com/en-us/library/471w8d85(v=vs.110).aspx

```c#
   while (true)
   {
       var keyPressed = Console.ReadKey().Key;
       if (keyPressed == ConsoleKey.Enter)
       {
           Console.BackgroundColor = ConsoleColor.DarkBlue;
           Console.Clear();
       }
       else if(keyPressed == ConsoleKey.Spacebar)
       {
           Console.WriteLine("SPACE");
       }
   }
```
