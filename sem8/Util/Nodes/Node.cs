using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem8.Util.Nodes
{
    public class Node
    {
        private Object Data{get;set;}
        public Node Left{get;set;}
        public Node Rigth{get;set;}
        public Node Father{get;set;}
        public Node(){
            Left= null;
            Rigth= null;
        }
        public Node(object o,Node Father){
            Data=o;
            Left= null;
            Rigth= null;
            this.Father= Father;
        }

        public object GetData(){
            return Data;
        }
        public bool HasLeft()=> Left!= null;
        public bool HasRigth()=> Rigth!= null;
        public bool HasFather()=>Father!=null;
        public void SetData(object e)=>Data=e;

    }
}