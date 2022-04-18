
Console.WriteLine("First test case");
SymmetricalDifference.PrintUniqueNumbers(new List<int[]>(){
    new int[] {1,2,3},
    new int[] {1,3,4}
});

Console.WriteLine("Second test case");
SymmetricalDifference.PrintUniqueNumbers(new List<int[]>(){
    new int[] {1,2,3},
    new int[] {1,3,4},
    new int[] {4,5,6}
});

Console.WriteLine("Third test case");
SymmetricalDifference.PrintUniqueNumbers(new List<int[]>(){
    new int[] {1,2,2,3,4},
    new int[] {1,5,5,6}
});


public static class SymmetricalDifference
{
    static readonly Dictionary<int, bool> UniqueInts = new();

    public static void PrintUniqueNumbers(IEnumerable<int[]> arrays)
    {
        foreach (var i in arrays)
        {
            var tmp = i.Distinct();
            foreach (var j in tmp)
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