using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace sem6.Classes.Stack
{
    public class Stack
    {
        public LinkedList.LinkedList data;
        public Stack(){
            data= new LinkedList.LinkedList();
        }
        public  int Size(){
            return data.Size();
        }
        public bool IsEmpty(){
            return data.IsEmpty();
        }
        public void push(object e){
            data.Agregar(e);
        }
        public object Pop(){
            //may return only the value to typecast
            return data.Pop().Valor;
        }
        public object Top(){
            if (data.Cabeza != null)
            {
                return data.Cabeza.Valor;
                
            }else
            {
                return null;
            }
        }


    }
}