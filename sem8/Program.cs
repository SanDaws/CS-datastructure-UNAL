
using sem8.classes;
using sem8.Util;
using sem8.Util.Nodes;

namespace sem8;

class Program
{
    static void Main(string[] args)
    {
        // planb();
     Problema1 pb= new Problema1();

        Recorrido r= new Recorrido();
        pb.bst.insert("camilo",7);
        pb.bst.insert("andres",12);
        pb.bst.insert("Vanesa",1);
        pb.bst.insert("Miguel",15);
        pb.bst.insert("Salomon",13);
        pb.bst.insert("Arturo",6);

        // pb.newdato();
        // Console.WriteLine();
        // pb.Eliminar();
        // Console.WriteLine();
        // pb.Encontrar();
        // Console.ReadKey();
        // Console.WriteLine();
        // pb.Smallest();
        // Console.ReadKey();
        // Console.WriteLine();
        // pb.Bigest();
        // Console.ReadKey();
        // Console.WriteLine();
        // pb.PrintTree();
        Console.ReadKey();
        Console.WriteLine();
        pb.Ordenado();
        Console.ReadKey();
        Console.WriteLine();





    }
    static void planb(){
        Console.Clear();
        Console.WriteLine("Hello, World!");
        BinarySearchTree bst= new BinarySearchTree();
        Recorrido r= new Recorrido();
        bst.insert("camilo",7);
        bst.insert("andres",12);
        bst.insert("Vanesa",1);
        bst.insert("Miguel",15);
        bst.insert("Salomon",13);
        bst.insert("Arturo",6);
        Recorrido.InOrder(bst,bst.Root());
        List<Node> lst= r.Result();
        foreach (Node obj in lst)
        {
            BSTEntry yte= (BSTEntry)obj.GetData();//look what iis this from
            Console.Write(yte.Key + ", ");
            
            
        }
        Node found= bst.find(7);

    }


}
