Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
if (b > 0)
    {
        double c = Math.Pow(a, b); 
        Console.WriteLine($"A в степени B равно {c}");
    }
    
   else 
   {
    Console.WriteLine("ERROR");
   }




