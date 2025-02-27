using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace sem6.Classes.LinkedList;
public class LinkedList
{
    public Node Cabeza;
    public Node Cola;
    private int size;

    public LinkedList(){
        Cabeza= null;
        Cola=null;
        size =0;
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
    size++;
        
    }
    public void Agregar(Node nodo) {
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
    size++;
        
    }
    public Node Shift(){
        Node node= Cabeza;
        if (Cabeza== null)
        {
            return null;
        }
        Cabeza= Cabeza.Siguiente;


        return node;

    }
    public Node Pop(){
        Node node;
        
         if (Cabeza == null) {
        return null;
    }

    if (Cabeza.Siguiente == null) {
        node = Cabeza;
        Cabeza = null;
        Cola = null;
        return node;
    }


    Node actual = Cabeza;
    while (actual.Siguiente != Cola) {
        actual = actual.Siguiente;
    }

    node = Cola;

    actual.Siguiente = null;
    Cola = actual;

    return node;
    }

    public void Unshift(object valor){
        Node node= new Node(valor);
        node.Siguiente= Cabeza;
        Cabeza=node;
    }
    public int Size(){
        return size;
    }
    public bool IsEmpty(){
        if (Cabeza == null)
        {
            return true;
        }
        return false;
        
    }
}
