using inve_inve.Models;

namespace inve_inve;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Fecha fc= new Fecha(12,12,21);
        Direccion dr= new Direccion();
        Empleado mp= new Empleado(123,"jaime velez",fc,"bogota",321321,"jv1@gmail.com",dr);
        Equipo eq=new Equipo("gramulo","A53",Fecha.Now(),1561);
        mp.Inventario.Add(eq);
        mp.Inventario.Add(eq);
        Console.WriteLine(eq.ToString());

        Console.WriteLine(mp.ToString());
        Credencial cr=new Credencial("151681335","Pass*0");
        Console.WriteLine(cr.ToString());
        
    }
}
