using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using sem8.Util.Nodes;

namespace sem8.Util
{
    public class BinarySearchTree:BinaryTree
    {
        public BinarySearchTree():base(){  

        }
        public Node find(int k){
            return Searhtree(k,Root());
        }
        public void insert(object e, int k){
            BSTEntry Newone= new BSTEntry(e,k);
            if (IsEmpty())
            {
                InsertRoot(Newone);
            }else
            {
                AddEntry(Root(),Newone);
            }
        }
        public void Remove(int k){
            Node n= find(k);
            BSTEntry tmp= (BSTEntry)n.GetData();
            if (n.HasLeft()& n.HasRigth()){
                Node t= Predecesor(n);
                n.SetData(t.GetData);
                base.Remove(t); 
            }else{
                base.Remove(n);
            }
        }
        public Node Predecesor(Node Ndo){
            Node temp=  Ndo.Left;
            return maxNode(temp);
        }
        public Node maxNode(Node t){
            if(t.HasRigth()){
                return maxNode(Right(t));
            }else
            {
                return t;
            }
        }
        public Node minNode(Node t){
            if(t.HasLeft()){
                return minNode(Left(t));
            }else
            {
                return t;
            }
        }
        private Node Searhtree(int k, Node n){
            BSTEntry comi= (BSTEntry)n.GetData();
            if (k==comi.Key)
            {
                return n;
            }else {
                if(k< comi.Key){
                    return Searhtree(k,n.Left);
                }else{
                    return Searhtree(k,n.Rigth);
                }
                   
            }
            
        }
        private void AddEntry(Node n, BSTEntry b){
            BSTEntry comin= (BSTEntry)n.GetData();
            if (comin.Key>b.Key){
                if (n.HasLeft())
                {
                    AddEntry(n.Left,b);
                }else{
                    InsertLeft(n,b);
                }
                
            }
            if (comin.Key<b.Key){
                if (n.HasRigth())
                {
                    AddEntry(n.Rigth,b);
                }else{
                    InsertRigth(n,b);
                }
                
            }

            
        }
    }
}