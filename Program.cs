
Console.WriteLine("First test case");
SymetricalDifference.PrintUniqueNumbers(new List<int[]>(){
    new int[] {1,2,3},
    new int[] {1,3,4}
});

Console.WriteLine("Second test case");
SymetricalDifference.PrintUniqueNumbers(new List<int[]>(){
    new int[] {1,2,3},
    new int[] {1,3,4},
    new int[] {4,5,6}
});


public static class SymetricalDifference
{
    static readonly Dictionary<int, bool> UniqueInts = new();

    public static void PrintUniqueNumbers(IEnumerable<int[]> arrays)
    {
        foreach (var i in arrays)
        {
            foreach (var j in i)
            {
                if (!UniqueInts.ContainsKey(j))
                {
                    UniqueInts.Add(j, true);
                }
                else
                {
                    UniqueInts[j] = false;
                }
            }
        }

        foreach (var num in UniqueInts)
        {
            if (num.Value)
                Console.WriteLine(num.Key);
        }
        UniqueInts.Clear();
    }
}