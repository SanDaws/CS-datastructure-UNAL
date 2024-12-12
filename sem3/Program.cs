using sem3.Classes;
using Sem3.Classes;

namespace sem3;

class Program
{
    public static void Main(string[] args)
    {
Agenda agenda;
        Console.WriteLine($"""
        menu:
            1: importar
            2: exportar
            3: salir
        """);
        while (true)
        {
            ConsoleKeyInfo option= Console.ReadKey();
            switch (option.Key)
            {
                case ConsoleKey.D1:
                agenda= new Agenda(12);
                Programexport(agenda);

                break;
                case ConsoleKey.D2:
                agenda= new Agenda(12);
                Programimport(agenda);
                break;

                default:
                Console.WriteLine("invalidkey");
                break;
            }
            
        }

    }
    private static void Programexport(Agenda Agenda){
        seed(Agenda);
        Buscar(Agenda);
        Agenda.ToFile();
        
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
        Console.WriteLine(Agenda.show(i).ToString());
        }
    private static void Programimport(Agenda agenda){
        agenda.Import();
        foreach (Usuario user in agenda.getRegistros())
        {
            Console.WriteLine(user.ToString());
        }
        deleting(agenda);
        Console.WriteLine("To agenda");
        agenda.ToFile();

        
    }
    private static void seed(Agenda Agenda){
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
        
        Agenda.Agregar(usuario1);
        Agenda.Agregar(usuario2);
        Agenda.Agregar(usuario3);
        Agenda.Agregar(usuario4);
Agenda.Agregar(usuario5);
        
    }

}
