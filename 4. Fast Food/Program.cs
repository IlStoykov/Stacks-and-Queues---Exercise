
int food = int.Parse(Console.ReadLine());
int[] entr = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> orders = new Queue<int>(entr);
Console.WriteLine(orders.Max());

while (orders.Count > 0 && food > 0) 
{    
    int order_check = orders.Peek();

    if (food >= order_check)
    {
        orders.Dequeue();
        food -= order_check;
    }
    else 
    {
        break;
    }
    
}
if (orders.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else 
{
    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
}



