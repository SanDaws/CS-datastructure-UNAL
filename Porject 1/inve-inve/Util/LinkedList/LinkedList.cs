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
            Cola= Cabeza.Siguiente;
        }
        else
        {
            Node actual = Cola;
            actual.Siguiente = newnode;
        }
        
    }
    public void Agregar(Node nodo)
    {

        if (Cabeza == null)
        {
            Cabeza = nodo;
            Cola= Cabeza.Siguiente;
        }
        else
        {
            Node actual = Cola;
            actual.Siguiente = nodo;
        }
        
    }
    public Node eliminarCabezaSoft(){
        Node node= Cabeza;
        Cabeza= Cabeza.Siguiente;
        return node;

    }
    }
}