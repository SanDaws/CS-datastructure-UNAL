using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inve_inve.Util.LinkedList
{
    public class LinkedList
    {
    public Node Cabeza;
    public Node Cola;

    public LinkedList(){
        Cabeza= null;
        Cola=null;
    }
    public void Agregar(object valor)
    {
        Node newnode = new Node(valor);

        if (Cabeza == null)
    {

        Cabeza = newnode;
        Cola = newnode;
    }
    else
    {
        Cola.Siguiente =newnode;
        Cola= newnode;           
    }
        
    }
    public void 
    Agregar(Node nodo)
    {
        nodo.Siguiente=null;

        if (Cabeza == null)
        {
            Cabeza = nodo;
            Cola= nodo;
        }
        else
        {
           Cola.Siguiente =nodo;
            Cola= nodo;   
        }
        
    }
    public Node eliminarCabezaSoft(){
        Node node= Cabeza;

        Console.WriteLine();
        Console.WriteLine(Cabeza==null);
        Cabeza= Cabeza.Siguiente;
        
        return node;

    }
    }
}