int round = int.Parse(Console.ReadLine());
string text = string.Empty;
Stack<string> states = new Stack<string>();
for (int i = 0; i < round; i++)
{
    string[] entr = Console.ReadLine().Split();
    string command = entr[0];
    
    if (command == "1")
    {
        states.Push(text);
        string worktext = entr[1];
        text += worktext;        
    }
    else if (command == "2")
    {
        states.Push(text);
        string worktext = entr[1];
        int count = int.Parse(worktext);
        text = text.Substring(0, text.Length - count);
        
    }
    else if (command == "3")
    {
        string worktext = entr[1];
        int index = int.Parse(worktext);
        if (index <= text.Length)
        {
            Console.WriteLine(text[index - 1]);
        }
    }
    else if (command == "4")
    {
        text = states.Pop();        
    }
}