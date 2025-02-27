using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sem6.Classes.LinkedList;
using sem6.Classes.User;

namespace sem6.Classes.Queue;
    public class Queue
    {
        public LinkedList.LinkedList data;
        public Queue(){
            data=  new LinkedList.LinkedList();
        }
        public  int Size(){
            return data.Size();
        }
        public bool IsEmpty(){
            return data.IsEmpty();
        }
        public void Enqueue(object e){
            data.Agregar(e);
        }
        public object Dequeue(){
            Node o=data.Shift();
            if (o == null)
            {
                Console.WriteLine("empty queue");
                return null;
            }
            
            return o.Valor;
        }
        public object first(){
            if (data.Cabeza==null)
            {
                return null;
            }
            return data.Cabeza.Valor;
        }
        public List<string> FormatAll(){
            List<string> db=new List<string>();
            Node node= data.Cabeza;

            if(node != null){
             while (node!=null){
                Empleado cb= (Empleado)node.Valor;
               db.Add(cb.ToString());
               node=node.Siguiente;
            }
            }
                
            return db;
        }
        


        
    }
