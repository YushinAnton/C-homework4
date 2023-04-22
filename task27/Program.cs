int Sum(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        result += i;
    }
    return result;
}
Console.WriteLine(Sum(int.Parse(Console.ReadLine())));