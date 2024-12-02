var occurences1 = new Dictionary<int, int>() ;
var occurences2 = new Dictionary<int, int>();

using var s = new StreamReader("./input");
while (s.ReadLine() is { } line)
{
    AddOccurence(occurences1, int.Parse(line[..5]));
    AddOccurence(occurences2, int.Parse(line[8..]));
}

int total = 0;
foreach(var o in occurences1)
{
    if(occurences2.TryGetValue(o.Key, out var o2Score))
    {
        total += o.Key * o.Value * o2Score;
    }
}

Console.WriteLine(total);
Console.ReadLine();

static void AddOccurence(Dictionary<int, int> occurences, int l1Value)
{
    if (!occurences.TryGetValue(l1Value, out int value))
    {
        occurences.Add(l1Value, 1);
    }
    else
    {
        occurences[l1Value] = ++value;
    }
}