using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sem8.Util.Nodes;
using sem6.Classes;
using sem6.Classes.Queue;

namespace sem8.Util
{
    public class BinaryTree
    {
        private Node root;
        private int size;
        public BinaryTree(){
            root = null;
            size = 0;

        }
        public int Size()=> size;
        public bool IsEmpty()=> size==0;
        public bool IsRoot(Node n)=> n==root;
        public bool IsInternal(Node n)=> n.HasLeft() | n.HasRigth();
        public Node Root()=> root;
        public Node Left(Node n)=>n.Left;
        public Node Right(Node n)=> n.Rigth; 
        public int Height(Node n){
            if (IsInternal(n))
            {
                return 0;
                
            }else
            {
                int h = 0;
                h= Math.Max(Height(Left(n)),Height(Right(n)));
                return h+1;
            }
        }
        public int Depth(Node n){
            if (IsRoot(n)){
                return 0;
            }else{
                return 1+Depth(Parent(n));//falta parent
            }
        }
        public Node Parent(Node n){
            if (IsRoot(n)){
                return null;
            }else{
                Queue q= new Queue();
                q.Enqueue(root);
                Node tmp= root;
                while (!q.IsEmpty() & (Left((Node)q.first().Valor) != n) & Right((Node)q.first().Valor) != n)
                {
                    tmp = (Node)q.Dequeue();
                    if (tmp.HasLeft()){
                        q.Enqueue(Left(tmp));
                    }
                    if (tmp.HasRigth()){
                        q.Enqueue(Right(tmp));
                    }
                }
                return tmp;
            }

        }
        public void InsertRoot(object e){
            Node newRoot= new Node(e,root);
            root=newRoot;
            size ++;
        }
        public void InsertLeft(Node n, object value){
            Node newLeftNode= new Node(value,n);
            n.Left=newLeftNode;
            size ++;
        }
        public void InsertRigth(Node n, object value){
            Node newRightNode= new Node(value,n);
            n.Rigth=newRightNode;
        }
        public void Remove(Node n){
           //guia
            Node p = n.Father;
            Node child=null;
            // if (n.HasLeft()|| n.HasRigth()){
            //     if (n.HasLeft()){
            //          child=Left(n);
            //     }else
            //     {
            //         child=Right(n);
            //     }
            //     if (Left(p)==n){
            //         p.Father=child;
                
            //     }
            //     n.Father=null;
            // }else{
            //     if (Left(p)==n)
            //     {
            //         p.Father=null;
            //     }
            // }
            //mi nodo tiene un nodo padre asi que:
            if (n.HasLeft()|| n.HasRigth()){
                if (n.HasLeft())
                {
                    child=Left(n);
                }
                if (n.HasRigth())
                {
                    child=Right(n);
                }
                if (p.Left==n)
                {
                    p.Left=child;
                }
                if (p.Rigth==n)
                {
                    p.Rigth=child;    
                }
                n.Left=null;
                n.Rigth=null;
            }else
            {
                if(p.Left==n){
                    p.Left=null;
                }else{
                    p.Rigth=null;
                }
            }
            size --;
        }
       // Recorrido
      

    }
}