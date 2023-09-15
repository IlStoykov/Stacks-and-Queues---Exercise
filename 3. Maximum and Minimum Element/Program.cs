int round = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < round; i++) 
{
    int[] entr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    

    if (entr[0] == 1) 
    {
        stack.Push(entr[1]);
    } 
    else if (entr[0] == 2) 
    {
        stack.Pop();
    }
    else if (entr[0] == 3 && stack.Count > 0)
    {
        Console.WriteLine(stack.Max());
    }
    else if (entr[0] == 4 && stack.Count > 0) 
    {
        Console.WriteLine(stack.Min());
    }
}
Console.WriteLine(string.Join(", ", stack));
