int count = int.Parse(Console.ReadLine());

HashSet<string> list = new HashSet<string>();
for (int i = 0; i < count; i++)
{
    string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    foreach (string line in info)
    {
        list.Add(line);
    }
}
list = list.OrderBy(x => x).ToHashSet();
Console.WriteLine(string.Join(" ",list));