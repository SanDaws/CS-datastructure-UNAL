using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



public class Heap
{
    private object[] A;
    private int size;


    public Heap(int capacity)
    {
        A = new object[capacity];
        size = 0;
    }

// Returns index of father(center)
    public int Parent(int i)
    {
        return (i - 1) / 2;
    }

// Returns index of lefty son at i position
    public int Left(int Posicion)
    {
        return 2 * Posicion + 1;
    }

// Returns index 
    public int Right(int Posicion)
    {
        return 2 * Posicion + 2;
    }


    public void 
    MaxHeapify(int i)
    {
        int l = Left(i);
        int r = Right(i);
        int largest = i;


        if (l < size && Comparer<object>.Default.Compare(A[l], A[i]) > 0)
        {
            largest = l;
        }


        if (r < size && Comparer<object>.Default.Compare(A[r], A[largest]) > 0)
        {
            largest = r;
        }


        if (largest != i)
        {
            Swap(i, largest);
            MaxHeapify(largest);
        }
    }


    public void BuildMaxHeap(object[] B)
    {
        if (B.Length > A.Length)
        {
            throw new ArgumentException("El arreglo B es más grande que la capacidad del montículo.");
        }


        Array.Copy(B, A, B.Length);
        size = B.Length;


        for (int i = size / 2 - 1; i >= 0; i--)
        {
            MaxHeapify(i);
        }
    }


    public void HeapSort()
    {

        BuildMaxHeap(A);


        for (int i = size - 1; i > 0; i--)
        {

            Swap(0, i);
            size--;


            MaxHeapify(0);
        }
    }


    private void Swap(int i, int j)
    {
        object temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    }


    public void PrintHeap()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
    }
}