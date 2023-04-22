Console.WriteLine("введите число ");
int number = int.Parse(Console.ReadLine());
int[] Array = new int[number];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1,100);
    //Console.Write(Array[i] + " ");
}
Console.Write(Array[i] + " ");
