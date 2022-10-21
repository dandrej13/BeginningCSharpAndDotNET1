
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = GenerateLotsOfNumbers(12045678);
        var queryRes =
            from n in numbers
            where n < 1000
            select n;

        foreach(var item in queryRes)
        {
            Console.WriteLine(item);
        }

}

    private static int[] GenerateLotsOfNumbers(int v)
    {
        Random random = new Random();
        int[] numbers = new int[v];
        for (int i = 0; i < v; i++)
        {
            numbers[i] = random.Next(0, v);
        }
            return numbers;
    }


    
}
