using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sem4.Nodes;

namespace sem4.LinkedList;
public class SimpleList
{
    private SimpleNode Cabeza;
    private SimpleNode Cola;

    public SimpleList(){
        Cabeza= null;
        Cola=null;
    }
    public void Agregar(int valor)
    {
        SimpleNode nuevoSimpleNode = new SimpleNode(valor);

        if (Cabeza == null)
        {
            Cabeza = nuevoSimpleNode;
            Cola= Cabeza.Siguiente;
        }
        else
        {
            SimpleNode actual = Cola;
            actual.Siguiente = nuevoSimpleNode;
        }
        
    }

}
