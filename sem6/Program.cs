
using sem6.Classes.Queue;
using sem6.Classes.Stack;
using sem6.Classes.User;

namespace sem6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        NumbersStack();
        Numbersque();
        Userquewe();


    }
    public static void NumbersStack()
    {
        Console.Clear();
        Stack stk = new Stack();
        stk.push(2);
        stk.push(4);
        stk.push(6);
        stk.push(8);
        stk.push(10);
        for (int i = 0; i < stk.Size(); i++)
        {
            int val = Convert.ToInt32(stk.Pop());
            Console.WriteLine(val);
        }
        Console.ReadKey();
    }
    public static void Numbersque()
    {
        Console.Clear();
        Queue queue = new Queue();
        queue.Enqueue(2);
        queue.Enqueue(4);
        queue.Enqueue(6);
        queue.Enqueue(8);
        queue.Enqueue(10);
        for (int i = 0; i < queue.Size(); i++)
        {
            int val = Convert.ToInt32(queue.Dequeue());
            Console.WriteLine(val);
        }
        Console.ReadKey();
    }
    public static void Userquewe()
    {
        Console.Clear();
        TurnoUsuario tu = new TurnoUsuario();
        tu.UploadFromFile();


        string? nom;
        int ced;
        Empleado registrador = new Empleado(11, "Rodrigo");
        Console.WriteLine("ingrese su cedula");
        int log = int.Parse(Console.ReadLine());
        if (log != registrador.Id)
        {

            Console.WriteLine("--llene los campos con : '0' , para salir--");

            do
            {

                Console.Write("ingrese su nombre: ");
                nom = Console.ReadLine();
                Console.Write("ingrese su cedula: ");
                ced = int.Parse(Console.ReadLine());


                if ((nom == "0" && ced == 0) || string.IsNullOrWhiteSpace(nom))
                {
                    Console.WriteLine("adios");
                    break;
                }
                else
                {
                    tu.registrar(new Empleado(ced, nom));
                    Console.WriteLine("Listo, espere su turno");
                    Console.ReadKey();
                }
            } while (true);

        }
        else
        {
            bool loop=true;
            Console.WriteLine("Bienvenid@, oprima 1 para empezar a atender");
            Console.WriteLine("0 para salir");
            while (loop)
            {
                ConsoleKeyInfo a = Console.ReadKey();

                switch (a.Key)
                {
                    case ConsoleKey.D1:
                        Empleado e = tu.atenderSiguiente();
                        if(e!= null){Console.WriteLine($""" 
                Nombre: {e.Nombre}
                Cedula: {e.Id}
                """);}else
                {
                    loop=false;
                }
                        break;
                    case ConsoleKey.D0:
                    loop=false;
                        break;
                    default:
                        Console.WriteLine("equivocado");
                        break;
                }
            }



        }

        tu.AllToFile();
    }

}
