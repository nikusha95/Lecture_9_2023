// See https://aka.ms/new-console-template for more information

using System.Numerics;
using System.Runtime.Intrinsics;
using System.Threading.Channels;

int[] arr = new[] { 1, 2, 3 };

Console.WriteLine(arr[2]);

int[] arr1 = new int[arr.Length + 1];
arr.CopyTo(arr1, 0);
arr1[3] = 10;


List<int> lst = new(); //new List<int>()
lst.Add(1);
Console.WriteLine($"capacity {lst.Capacity}");
Console.WriteLine($"length {lst.Count}");
lst.Add(2);
Console.WriteLine($"capacity {lst.Capacity}");

lst.Add(900);
lst.Add(900);
lst.Add(900);

lst.Remove(900);
//int index = lst.FindIndex(10, x => x == 3);

lst.RemoveAll(x => x.Equals(900)); //lambda
Console.WriteLine($"capacity {lst.Capacity}");

Console.WriteLine("FOR:");
for (int i = 0; i < lst.Count; i++)
{
    Console.WriteLine(lst[i]);
}

Console.WriteLine("Foreach:");
foreach (var i in lst)
{
    Console.WriteLine(i);
}

Console.WriteLine();

List<int> list = new() { 1, 2, 4, 6456, 56 };

foreach (var l in list)
{
    Console.Write($"{l} ");
}

list.Add(10);

list.AddRange(new[] { 1, 2, 4 });
list.AddRange(new List<int> { 2131, 333, 2221 });
Console.WriteLine();
Console.WriteLine(list[^1]);


Console.WriteLine("Queues");
Queue<int> queue = new Queue<int>();
//FI-FO


queue.Enqueue(101);
queue.Enqueue(20);
queue.Enqueue(21);
Console.WriteLine($"peek {queue.Peek()}");

while (queue.Count > 0)
{
    Console.WriteLine($"count {queue.Count}");

    int el = queue.Dequeue(); //remove element
    Console.WriteLine($"element which has been removed :{el}");
}

//FILO
Stack<int> stack = new Stack<int>();

stack.Push(1); //10,5,1
stack.Push(1000); //10,5,1000,1
stack.Push(5);
stack.Push(10);

Console.WriteLine("Stack Sample");
Console.WriteLine(stack.Peek());

while (stack.Count != 0)
{
    Console.WriteLine($"count {stack.Count}");
    int el = stack.Pop(); //remove element
    Console.WriteLine($"element which has been removed :{el}");
}