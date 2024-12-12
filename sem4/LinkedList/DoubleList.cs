using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sem4.Nodes;

namespace sem4.LinkedList;
public class DoubleList{
    private DoubleNode Cabeza;
    private DoubleNode Cola;
    public DoubleList(){
        Cabeza= null;
        Cola=null;
    }
     public void Agregar(int valor)
    {
        DoubleNode nuevoSimpleNode = new DoubleNode(valor);

        if (Cabeza == null)
        {
            Cabeza = nuevoSimpleNode;
            Cola= Cabeza.Siguiente;
        }
        else
        {
            DoubleNode actual = Cola;
            nuevoSimpleNode.Anterior=Cola;
            actual.Siguiente = nuevoSimpleNode;
        }
        
    }




}
