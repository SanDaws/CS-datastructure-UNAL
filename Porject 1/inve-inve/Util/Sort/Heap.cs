using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Models;

namespace inve_inve.Util.Sort;
    public class Heap
    {
        public static void Sort(List<Equipo> lista)
    {
        int n = lista.Count;

        // Construir el heap máximo
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(lista, n, i);

        // Extraer elementos del heap uno por uno
        for (int i = n - 1; i > 0; i--)
        {
            // Intercambiar el primer elemento (máximo) con el último
            Swap(lista, 0, i);

            // Llamar a heapify en el heap reducido
            Heapify(lista, i, 0);
        }
    }

    private static void Heapify(List<Equipo> lista, int n, int i)
    {
        int largest = i; // Inicializar el nodo más grande como raíz
        int left = 2 * i + 1; // Hijo izquierdo
        int right = 2 * i + 2; // Hijo derecho

        // Si el hijo izquierdo es mayor que la raíz
        if (left < n && lista[left].Placa > lista[largest].Placa)
            largest = left;

        // Si el hijo derecho es mayor que el nodo más grande hasta ahora
        if (right < n && lista[right].Placa > lista[largest].Placa)
            largest = right;

        // Si el nodo más grande no es la raíz
        if (largest != i)
        {
            Swap(lista, i, largest);

            // Recursivamente heapify el subárbol afectado
            Heapify(lista, n, largest);
        }
    }

    private static void Swap(List<Equipo> lista, int i, int j)
    {
        Equipo temp = lista[i];
        lista[i] = lista[j];
        lista[j] = temp;
    }
        
    }

