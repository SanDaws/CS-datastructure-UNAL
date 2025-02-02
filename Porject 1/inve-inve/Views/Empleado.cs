using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Controllers;
using inve_inve.Models;
using inve_inve.Util;

namespace inve_inve.Views
{
    public class Empleado
    {
        EmpleadoController Ec;
        CredencialController cc;
        public Empleado(){
            Ec= new EmpleadoController();
            cc= new CredencialController();
        }
        public void Menu(){
        Util.Util.Title("Empleados",ConsoleColor.DarkBlue);
           Console.WriteLine("""
            seleccione alguna de las opciones:
            1: Registrar
            2: Eliminar
            3: Exportar empleado
            0: volver
            """);
            OptionSelector();
        }
        private  void OptionSelector(){
            Console.WriteLine("oprima el numeor de opcion");
            ConsoleKeyInfo key=Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                EmpleadoForm();
                Menu();

                break;
                case ConsoleKey.D2:
                Eliminar();
                Menu();
                break;
                case ConsoleKey.D3:
                UserToFile();
                Menu();
                break;
                
                case ConsoleKey.D0:
                break;
                
                default:
                Util.Util.RedText("opcion incorrecta");
                OptionSelector();
                break;
            }
        }



        //Crear un usuario
        //long id,string nombre,  Fecha fecha, string ciudadNacimeinto, long tel, string email, Direccion dir
        public void EmpleadoForm(){
            long id = Exceptions.safeInt("Cedula ");
            
            Console.Write("Nombre :");
            string nombre = Exceptions.AntiEMptyorNull();
            Console.WriteLine("Fecha de nacimiento :");

            Fecha fecha = _Fecha.FechaForm();

            Console.Write("Ciudad de nacimiento :");
            string ciudadNacimeinto = Exceptions.AntiEMptyorNull();

            long tel = Exceptions.safeInt("Telefono");

            Console.Write("email :");
            string email = Exceptions.AntiEMptyorNull();
            
            Console.WriteLine("Residencia :");
            Direccion dir = _Direccion.DireccionForm();

            Ec.CrearEmpleado(id, nombre, fecha, ciudadNacimeinto, tel, email, dir);
            Util.Util.GreenText("creado exitosamente");
            Console.WriteLine("Contraseña:");
            string pss = Exceptions.AntiEMptyorNull();
            
            cc.CreateCredentials(id.ToString(),pss);



        }
        
            //upoload to file a n specific 
            public void UserToFile(){
            long id = Exceptions.safeInt("Cedula ");
            Models.Empleado? emp = Ec.FindEmploye(id);
            while(emp == null){
                Util.Util.RedText("cedula no encontrada");
                id = Exceptions.safeInt("Cedula ");
                emp = Ec.FindEmploye(id);
            }
            string file=Ec.SaveinFile(emp);
            Util.Util.GreenText($"archivo creado sarisfactoriamente en : {file}");
            }
            //elimina un empleado
            public void Eliminar(){
                long id = Exceptions.safeInt("Cedula del empleado");
                bool foud=Ec.eliminarEmpleado(id);
                if (foud)
                {
                    Credencial? cre=cc.FindCredencial(id.ToString());
                cc.DeleteCredentials(cre);
                }
            }
        }
}