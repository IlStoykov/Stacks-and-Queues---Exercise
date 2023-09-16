

int[] entr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rack = int.Parse(Console.ReadLine());

Stack<int> box = new Stack<int>(entr);
int rackCount = 0;

while (box.Count > 0) {
    
    int rackCapacity = 0;
    
    while (true)        

        if (box.Count > 0) 
        {
            int testWear = box.Peek();
            if ((rackCapacity + testWear) > rack)
            {
                rackCount++;
                break;
            }
            else if (box.Count == 1) 
            {
                int usedWear = box.Pop();
                rackCount++;
                break;
            }
            else
            {
            int usedWear = box.Pop();
            rackCapacity += usedWear;

            }
        }
        else 
        { 
            break; 
        }
}
Console.WriteLine(rackCount);
