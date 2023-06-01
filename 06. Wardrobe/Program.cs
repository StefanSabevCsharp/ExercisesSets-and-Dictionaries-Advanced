int n = int.Parse(Console.ReadLine());

Dictionary<string,Dictionary<string,int>> wardrobe = 
    new Dictionary<string,Dictionary<string,int>>();
string[] delimeter = { " -> ", ", ", ",", " " };
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
    string color= command[0];
    for (int j = 1; j < command.Length; j++)
    {
        if (!wardrobe.ContainsKey(color))
        {
            wardrobe.Add(color, new Dictionary<string, int>());
        }
        if (!wardrobe[color].ContainsKey(command[j]))
        {
            wardrobe[color].Add(command[j],0);
        }
        wardrobe[color][command[j]]++;
    }
}
string[] searchedCloth = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
string searchedColor = searchedCloth[0];
string searchedWear = searchedCloth[1];

//foreach (var item in wardrobe)
//{
//    Console.WriteLine($"{item.Key} clothes:");

//    foreach (var clothes in item.Value)
//    {
//        string foundCloth = $"(found!)";

//        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
//    }
//}
foreach (var item in wardrobe)
{
    Console.WriteLine($"{item.Key} clothes:");

    foreach (var clothes in item.Value)
    {
        string foundCloth = "";

        if (item.Key == searchedColor && clothes.Key == searchedWear)
        {
            foundCloth = "(found!)";
        }

        Console.WriteLine($"* {clothes.Key} - {clothes.Value} {foundCloth}");
    }
}