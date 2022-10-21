    static int[] GenerateLotsOfNumbers(int count)
{
    Random generator = new Random(0);
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = generator.Next();
    }
    return result;
}

int[] numbers = GenerateLotsOfNumbers(12345678);

Console.WriteLine("Numeric Aggregates");
var queryResult =
     from n in numbers
     where n > 1000
     select n;

Console.WriteLine("Count of Numbers > 1000");
Console.WriteLine(queryResult.Count());
Console.WriteLine("Max of Numbers > 1000");
Console.WriteLine(queryResult.Max());
Console.WriteLine("Min of Numbers > 1000");
Console.WriteLine(queryResult.Min());
Console.WriteLine("Average of Numbers > 1000");
Console.WriteLine(queryResult.Average());
Console.WriteLine("Sum of Numbers > 1000");
Console.WriteLine(queryResult.Sum(n => (long) n));





