
namespace sem7;

class Program
{
    static void Main(string[] args)
    {
        wa();
        
    }
    public static void wa(){
        Heap heap = new Heap(10);

        object[] elements = { 4, 10, 3, 5, 1 };

        heap.BuildMaxHeap(elements);

        Console.WriteLine("Max-Heap:");
        
        heap.PrintHeap();
    }
}
