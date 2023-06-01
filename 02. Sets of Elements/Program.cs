int[]numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = numbers[0];
int m = numbers[1];
HashSet<int> nNumbers = new HashSet<int>();
HashSet<int> mNumbers = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    nNumbers.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0; i < m; i++)
{
    mNumbers.Add(int.Parse(Console.ReadLine()));
}

nNumbers.IntersectWith(mNumbers);
Console.WriteLine(string.Join(" ",nNumbers));