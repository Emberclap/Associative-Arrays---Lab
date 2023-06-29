namespace _3._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var words = new Dictionary<string,  List<string>>();
            
            
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                    words[word].Add(synonym);
                
            }
            foreach (var keyValuePair  in words)
            {
                Console.WriteLine($"{keyValuePair.Key} - {string.Join(", ", keyValuePair.Value)}");
            }
        }
    }
}