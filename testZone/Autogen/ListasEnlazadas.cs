using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testZone.Autogen
{
using System;

class ListaEnlazada
{
    private Nodo cabeza;
    private Nodo Cola;

    public ListaEnlazada(){
        cabeza = null;
    }


    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);

        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            Cola= cabeza.Siguiente;
        }
        else
        {
            Nodo actual = Cola;

            actual.Siguiente = nuevoNodo;
        }
    }

    // Método para imprimir los elementos de la lista
    public void Imprimir()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // Método para buscar un elemento en la lista
    public bool Buscar(int valor)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Valor == valor)
                return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    // Método para eliminar un nodo por valor
    public void Eliminar(int valor)
    {
        if (cabeza == null) return;

        // Caso especial: si el nodo a eliminar es la cabeza
        if (cabeza.Valor == valor)
        {
            cabeza = cabeza.Siguiente;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
    }
}


}