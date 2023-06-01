Dictionary<int,int> numbers = new Dictionary<int,int>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (!numbers.ContainsKey(num))
    { 
        numbers.Add(num, 0);
    }
    numbers[num]++;
}
var numb = numbers.First(x => x.Value % 2 == 0);
//numbers = numbers.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);

Console.WriteLine($"{numb.Key}");