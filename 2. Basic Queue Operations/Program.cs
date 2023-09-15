using System.Threading.Channels;

int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

int queueLength = commands[0];
int queueToPop = commands[1];
int queueToCheck = commands[2];

Queue<int>queue = new Queue<int>(values.Take(queueLength));

while (queue.Any() && queueToPop > 0) 
{
    queue.Dequeue();
    queueToPop--;
}
if (queue.Contains(queueToCheck))
{
    Console.WriteLine("true");
}
else if (queue.Count == 0)
{
    Console.WriteLine("0");
}
else 
{
    Console.WriteLine(queue.Min());
}

