using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem1.src;
public class Exc3{
    public static List<(string,string)> db= new List<(string, string)>();
    public static void Solution(){        
        Generate();
        int intentos=0;
        while (intentos<3){//O(n*2)
            (string,string) user= Asking();
            bool answer=db.Contains(user);
           if (answer){
             Console.WriteLine("Acceso permitido");
             break;
            }else{
             Console.WriteLine("Datos incorrectos”");
            intentos++;
            }      
            
        }
        if (intentos.Equals(3)){
            Console.WriteLine("Lo siento, su acceso no es permitido");
        }
            
    }
    private static void Generate(){
        //addition to a list is  O(1)
        db.Add(("Juan1223","J12an*."));
        db.Add(("Maria2345 ","M23a*."));
        db.Add(("Pablo1459","P14o*."));
        db.Add(("Ana3456 ","A34a*."));
        //O(4)=O(1)
    }
    private static (string,string) Asking(){
        Console.Write("inserte usuario");
        string? userpass = Console.ReadLine();
        Console.Write("inserte cojntraseña ");
        string? pass = Console.ReadLine();
        return (userpass,pass);
    }
    // 1+ (N*2)


}

