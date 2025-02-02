using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Controllers;
using inve_inve.Models;
using inve_inve.Util;

namespace inve_inve.Views
{
    public class Login
    {
        CredencialController credCon;
        public Login(){
            credCon= new CredencialController();
        }
        public Credencial  LoginForm(){
            Util.Util.Title("Ingresar",ConsoleColor.DarkRed);
            Console.Write("Documento: ");
            string cedula= Exceptions.AntiEMptyorNull();
            Console.Write("contraseña: ");
            string pass= Exceptions.AntiEMptyorNull();
            Credencial? result= credCon.Login(cedula,pass);
            if (result!=null)
            {
                return result;
            }
            else
            {
                Console.WriteLine("usuario o contraseña incorrectos");
                Console.WriteLine("oprima cualquier boton para reintentar");
                Console.ReadKey();
                LoginForm();
            }
            return result;

        }
        
    }
}