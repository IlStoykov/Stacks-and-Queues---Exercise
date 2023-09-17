int rounds = int.Parse(Console.ReadLine());
Queue<int[]> pumps = new Queue<int[]>();
for (int i = 0; i < rounds; i++) 
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    pumps.Enqueue(input);
}
int bestRoud = 0;
while (true) 
{
    int totalPetrol = 0;
    foreach (int[] pump in pumps) 
    {
        totalPetrol += pump[0];
        int curentPath = pump[1];
        if (totalPetrol < curentPath)
        {
            totalPetrol = 0;
            break;            
        }
        else 
        {
            totalPetrol -= curentPath;
        }
    }
    if (totalPetrol > 0) 
    {
        break;
    }
    bestRoud++;
    pumps.Enqueue(pumps.Dequeue());
}
Console.WriteLine(bestRoud);