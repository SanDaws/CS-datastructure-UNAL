using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sem8.Util;
using sem8.Util.Nodes;

namespace sem8.classes
{
    public class Problema1
    {
        public BinarySearchTree bst;
        public Problema1(){
            bst= new BinarySearchTree();
        }
        public void newdato(){
            
            Console.WriteLine("NUEVO INGRESO");
            Console.WriteLine("nuevo dato");
            string? dato= Console.ReadLine();
            Console.WriteLine("nueva clave");
            int clave= int.Parse(Console.ReadLine());
            bst.insert(dato,clave);

        }
        public void Eliminar(){
            Console.WriteLine("ELIMINAR");
            Console.WriteLine("Dato A eliminar");
            int clave= int.Parse(Console.ReadLine());
            bst.Remove(clave);
        }
        public void Encontrar(){
            Console.WriteLine("ENCONTRAR");
            Console.WriteLine("Dato A eliminar");
            int clave= int.Parse(Console.ReadLine());
            Node nd= bst.find(clave);
            BSTEntry obj= (BSTEntry)nd.GetData();
            Console.WriteLine(obj.ToString());
        }
        public void Smallest(){
            Console.WriteLine("MAS PEQUEÑO");
            Node smallestNode= bst.minNode(bst.Root());
            BSTEntry obj= (BSTEntry)smallestNode.GetData();
            Console.WriteLine(obj.ToString());

        }
        public void Bigest(){
            Console.WriteLine("MAS GRANDE");
            Node smallestNode= bst.maxNode(bst.Root());
            BSTEntry obj= (BSTEntry)smallestNode.GetData();
            Console.WriteLine(obj.ToString());
        }
        public void PrintTree()
        {
            Console.WriteLine("ARBOL");
            PrintTreeRec(bst.Root(), 0);
        }

        private void PrintTreeRec(Node root, int space)
        {
            const int COUNT = 4; // Espacio entre niveles
            if (root == null)
                return;

            // Aumentar la indentación para los niveles inferiores
            space += COUNT;

            // Procesar el hijo derecho primero
            PrintTreeRec(root.Rigth, space);

            // Imprimir el nodo actual después de los espacios
            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(root.GetData().ToString());

            // Procesar el hijo izquierdo
            PrintTreeRec(root.Left, space);
        }
        public void Ordenado(){
            Recorrido rc= new Recorrido();
            Recorrido.PosOrder(bst,bst.Root());
            List<Node> rasult= rc.Result();
            foreach (Node item in rasult)
            {
                BSTEntry kye= (BSTEntry)item.GetData();
                Console.Write($@"{kye.Key}, "); 
            }
            Recorrido.reset();
        }

    }
}