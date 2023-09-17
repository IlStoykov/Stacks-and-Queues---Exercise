string entr = Console.ReadLine();
Stack<char> stack = new Stack<char>();

foreach (char item in entr) 
{
    if (item == '(' || item == '[' || item == '{') 
    {
        stack.Push(item);
        continue;
    }
    if (stack.Count == 0) 
    {
        stack.Push(item);
        break;
    }
    else if (item == ')' && stack.Peek() == '(')
    {
        stack.Pop();
    }
    else if (item == ']' && stack.Peek() == '[')
    {
        stack.Pop();
    }
    else if (item == '}' && stack.Peek() == '{')
    {
        stack.Pop();
    }    
}
if (stack.Count() == 0)
{
    Console.WriteLine("YES");
}
else 
{
    Console.WriteLine("NO");
}
