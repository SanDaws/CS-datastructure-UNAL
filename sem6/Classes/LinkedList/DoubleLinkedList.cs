using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem6.Classes.LinkedList
{
    public class DoubleLinkedList{
    public DobleNode Cabeza;
    public DobleNode Cola;
    private int size;

    public DoubleLinkedList(){
        Cabeza= null;
        Cola=null;
        size =0;
    }
    public void Agregar(object valor)
    {
        DobleNode newnode = new DobleNode(valor);

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
    public void Agregar(DobleNode nodo) {
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
    public DobleNode Shift(){
        DobleNode node= Cabeza;


        Cabeza= Cabeza.Siguiente;
        
        return node;

    }
    public DobleNode Pop(){
        DobleNode node= Cola;
        Cola= null;
        DobleNode actual= Cabeza;
        if(actual!=null){
            while (actual.Siguiente != null){
            actual=actual.Siguiente;   
            }
        }
        Cola=actual;
        
        return node;

    }
    public void Unshift(object valor){
        DobleNode node= new DobleNode(valor);
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
}