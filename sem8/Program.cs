
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

        pb.newdato();
        Console.WriteLine();
        pb.Eliminar();
        Console.WriteLine();
        pb.Encontrar();
        Console.ReadKey();
        Console.WriteLine();
        pb.Smallest();
        Console.ReadKey();
        Console.WriteLine();
        pb.Bigest();
        Console.ReadKey();
        Console.WriteLine();
        pb.PrintTree();
        Console.ReadKey();
        Console.WriteLine();
        pb.Ordenado();
        Console.ReadKey();
        Console.WriteLine();
        problema2 problem2=new problema2();
        Per_sona p1= new Per_sona("Alberto","123");
        Per_sona p2= new Per_sona("Santiago","65463");
        Per_sona p3= new Per_sona("Ramiro","894651");
        Per_sona p5= new Per_sona("Michale","45266872");
        Per_sona p4= new Per_sona("Sebastian","218612");
        Per_sona p6= new Per_sona("Alberto","235485");
        Per_sona p7= new Per_sona("Vanessa","98415");
        problem2.bst.insert(p1,p1.key);
        problem2.bst.insert(p2,p2.key);
        problem2.bst.insert(p3,p3.key);
        problem2.bst.insert(p4,p4.key);
        problem2.bst.insert(p5,p5.key);
        problem2.bst.insert(p6,p6.key);
        problem2.bst.insert(p7,p7.key);
        problem2.Bigest();




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
