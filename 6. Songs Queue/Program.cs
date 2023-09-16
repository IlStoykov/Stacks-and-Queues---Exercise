string[] entr = Console.ReadLine().Split(", ").ToArray();
Queue<string> songs = new Queue<string>(entr);

while (songs.Count > 0) 
{
    string[] commandLine = Console.ReadLine().Split(" ");
    string command = commandLine[0];
    if (command == "Add")
    {
        string song = string.Join(" ", commandLine.Skip(1));
        if (!songs.Contains(song))
        {
            songs.Enqueue(song);
                       
        }
        else
        {
            Console.WriteLine($"{song} is already contained!");
        }
    }
    else if (command == "Play")
    {
        if (songs.Count == 1)
        {
            songs.Dequeue();
            Console.WriteLine("No more songs!");
            break;
        }
        else
        {
            songs.Dequeue();            
        }
    }
    else if (command == "Show") 
    {
        Console.WriteLine(string.Join(", ", songs).Trim());
    }

}

