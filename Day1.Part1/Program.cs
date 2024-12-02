var l1 = new List<int>();
var l2 = new List<int>();

using var s = new StreamReader("./input");
while (s.ReadLine() is { } line)
{
    l1.Add(int.Parse(line[..5]));
    l2.Add(int.Parse(line[8..]));
}

l1.Sort();
l2.Sort();

int total = 0;
for (int i = 0; i < l1.Count; i++)
{
    total += Math.Abs(l1[i] - l2[i]);
}

Console.WriteLine(total);
Console.ReadLine();