using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sem8.Util.Nodes;

namespace sem8.Util;
    public  class Recorrido
    {
        private static List<Node> order;
        public Recorrido(){
            order=new List<Node>();
        }
        public static void InOrder(BinaryTree bt,Node t)
        {

            if (t.HasLeft())
            {
                InOrder(bt,bt.Left(t));
            }
            visitar(t);

            if (t.HasRigth())
            {
                InOrder(bt,bt.Right(t));
            }
        }
        public static void PosOrder(BinaryTree bt,Node t)
        {

            if (t.HasLeft())
            {
                PosOrder(bt,bt.Left(t));
            }
            if (t.HasRigth())
            {
                PosOrder(bt,bt.Right(t));
            }
            visitar(t);

        }
        public static void PreOrder(BinaryTree bt,Node t)
        {
            visitar(t);

            if (t.HasLeft())
            {
                PreOrder(bt,bt.Left(t));
            }
            if (t.HasRigth())
            {
                PreOrder(bt,bt.Right(t));
            }
        }
        public static void visitar(Node nodito){
            if(nodito!=null){order.Add(nodito);}


        }
        public static void reset()=>order=null;
        public List<Node> Result()=> order;
    }
