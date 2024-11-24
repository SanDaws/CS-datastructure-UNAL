using Sem2.src;

namespace Sem2;

class Program
{
    /*This folder distribution is not usual in a .Net project
    becuase we dont use a "src folder,insted a "class" folder, 
    but, for some reason i just called src,but it will be a pain in 
    the neck to change the name right now
    */
    static void Main(){
        Console.Write(Seed());
        Console.WriteLine(CreateUsuario().Format());
    }
    public static string Seed(){
        Direccion dir= new Direccion("calle 76E","81c09","Villa flora","Medellin","","");
        Fecha fecha= new Fecha(09,03,22);
        Usuario yo= new Usuario(1007226999,"santiago Castro Giraldo",fecha,"Manizales",3224495321,"sacastro@unal.edu.co",dir);
        return yo.Format();
    }   
    public static Direccion CreateDir(){
        Console.Write("Calle: ");
        string calle=Console.ReadLine();

        Console.Write("Nomenclatura: ");
        string nomenclatura=Console.ReadLine();

        Console.Write("Barrio: ");
        string barrio=Console.ReadLine();

        Console.Write("Ciudad: ");
        string ciudad=Console.ReadLine();

        Console.Write("Edificio(opcional): ");
        string edificio=Console.ReadLine();

        Console.Write("Apartamento(opcional): ");
        string apto=Console.ReadLine();

        Direccion dir= new Direccion(calle,nomenclatura,barrio,ciudad,edificio,apto);
        return dir;
    }
    public static Fecha CreateFecha(){
        Console.Write("Dia de nacimiento: ");
        short dd=short.Parse(Console.ReadLine());

        Console.Write("Mes de nacimiento: ");
        short mm=Convert.ToSByte(Console.ReadLine());

        Console.Write("año de nacimiento: ");
        short yy=short.Parse(Console.ReadLine());
        Fecha fecha=new Fecha(dd,mm,yy);
        return fecha;
    }
    public static Usuario CreateUsuario(){
        
        Console.Write("Identificacion: ");
        long id=Convert.ToInt64(Console.ReadLine());
        
        Console.Write("nombre: ");
        string nombre=Console.ReadLine();

        Console.Write("Telefono: ");
        long tel=Convert.ToInt64(Console.ReadLine());
        
        Console.Write("Ciudad de nacimiento: ");
        string ciudadNacimiento=Console.ReadLine();
        
        Console.Write("Correo: ");
        string email=Console.ReadLine();
        
        Usuario persona= new Usuario(id,nombre,CreateFecha(),ciudadNacimiento,tel,email,CreateDir());

        return persona;

    } 
}
