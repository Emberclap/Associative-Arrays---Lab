namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> keyValuePairs = new SortedDictionary<double, int>();
            int count = 1;
            foreach (double number in numbers)
            {
                if (keyValuePairs.ContainsKey(number))
                {
                    keyValuePairs[number]++;
                }
                else
                {
                    keyValuePairs.Add(number, 1);
                }
            }
            foreach (var number in keyValuePairs)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}