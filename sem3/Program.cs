using Sem3.Classes;

namespace sem3;

class Program
{
    public static void Main(string[] args)
    {
        MainMenu();

    }
    public static void MainMenu(){
        Agenda agenda;
        Console.WriteLine($"""
        menu:
            1: exportar
            2: importar
            3: salir
        """);
    
        ConsoleKeyInfo option= Console.ReadKey();
        Console.WriteLine();
        switch (option.Key)
        {
            case ConsoleKey.D1:
            Programexport();

            break;
            case ConsoleKey.D2:
            agenda= new Agenda(12);
            Programimport(agenda);

            break;

            default:
            Console.WriteLine("invalidkey");
            MainMenu();
            break;
        }
        
        
    }
    private static void Programexport(){
        Agenda Agend;
        Agend=seed();
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();

        Console.Clear();
        Buscar(Agend);
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("importando");
        Agend.ToFile();
        
    }
    private static void Programimport(){
       Agenda agenda;
       agenda= Agenda.Import();
        Usuario[] user= agenda.getRegistros();
        Console.WriteLine(user[0]);
        // foreach (Usuario use in agenda.getRegistros())
        // {
        //     Console.WriteLine(user.Format());
        // }
         Console.WriteLine("press any key to continue...");
        Console.ReadKey();
        deleting(agenda);
         Console.WriteLine("press any key to continue...");
        Console.ReadKey();
        Console.WriteLine("To agenda");
        agenda.ToFile();

        
    }
    private static void deleting(Agenda Agenda){
        Console.WriteLine("------ deleting ");
        Console.Write("numero de identificacion a eliminar");
        long res= long.Parse(Console.ReadLine());
        Console.WriteLine(Agenda.Eliminar(res)?"eliminado satiasfactoriamente":"Elemento no encotnrado");
        }
    private static void Buscar(Agenda Agenda){
        Console.WriteLine("------ searching ");
        Console.Write("numero de identificacion a buscar");
        long res= long.Parse(Console.ReadLine());
        int i=Agenda.Buscar(res);
        if (i > -1){Console.WriteLine(i);}
        
        }
    
    private static Agenda seed(){
        Console.WriteLine("seeding");
        Agenda Agenda = new Agenda(7);
        Console.WriteLine(Agenda.getRegistros().Length);
        Fecha f1= new Fecha(21,12,2000);
        Fecha f3= new Fecha(12,1,2000);
        Fecha f2= new Fecha(15,10,2000);
        Fecha f4= new Fecha(12,1,2000);
        Fecha f5= new Fecha(15,10,2000);
        Direccion direccion1 = new Direccion("Calle 45", "#23-56", "La Castellana", "Bogotá", "Edificio Panorama", "101");
        Direccion direccion2 = new Direccion("Avenida Siempre Viva", "#742", "Springfield Central", "Springfield", "Torre A", "12B");
        Direccion direccion3 = new Direccion("Calle 8", "#56-78", "El Poblado", "Medellín", "Residencias El Pino", "304");
        Direccion direccion4 = new Direccion("Carrera 10", "#20-30", "San Isidro", "Barranquilla", "Edificio Azul", "402");
        Direccion direccion5 = new Direccion("Calle Principal", "#1A-99", "Centro Histórico", "Cartagena", "Conjunto Colonial", "B2");

        Usuario usuario1 = new Usuario(10156851203, "Juan Pérez", f1, "Bogotá", 1234567890L, "juan.perez@example.com", direccion1);
        Usuario usuario2 = new Usuario(26246816846, "Lisa Simpson", f2, "Springfield", 9876543210L, "lisa.simpson@example.com", direccion2);
        Usuario usuario3 = new Usuario(36246816846, "Carlos Gómez", f3, "Medellín", 1122334455L, "carlos.gomez@example.com", direccion3);
        Usuario usuario4 = new Usuario(46246816846, "Ana Torres", f4, "Barranquilla", 2233445566L, "ana.torres@example.com", direccion4);
        Usuario usuario5 = new Usuario(56246816846 ,"María López", f5, "Cartagena", 3344556677L, "maria.lopez@example.com", direccion5);
        
        bool ag1=Agenda.Agregar(usuario1);
        Console.WriteLine("seed: {0}", ag1?"succede":"failed");
        bool ag2=Agenda.Agregar(usuario2);
        Console.WriteLine("seed: {0}", ag2?"succede":"failed");
        bool ag3=Agenda.Agregar(usuario3);
        Console.WriteLine("seed: {0}", ag3?"succede":"failed");
        bool ag4=Agenda.Agregar(usuario4);
        Console.WriteLine("seed: {0}", ag4?"succede":"failed");
        bool ag5=Agenda.Agregar(usuario5);
        Console.WriteLine("seed: {0}", ag5?"succede":"failed");
        
        if (ag1&& ag2 && ag3 && ag4 && ag5){Console.WriteLine("succesfully seeded");}
        return Agenda;
    }

}
