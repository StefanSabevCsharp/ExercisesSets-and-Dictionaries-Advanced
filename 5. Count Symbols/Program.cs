SortedDictionary<char,int> data = new SortedDictionary<char,int>();
string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    char ch = input[i];
    if (!data.ContainsKey(ch))
    {
        data.Add(ch, 0);
    }
    data[ch]++;
}
foreach (var item in data)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}