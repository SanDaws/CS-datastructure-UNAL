using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Controllers;
using inve_inve.Models;
using inve_inve.Util;

namespace inve_inve.Views
{
    public class Menu
    {
        public static Credencial Userloged;
        CambioController cc;
        CredencialController CreC;
        EmpleadoController emC;

        public Menu(Credencial user){
            Userloged=user;  
            cc=new CambioController();
            CreC= new CredencialController();
            emC= new EmpleadoController();          
        }
        public  void MainMenu(){
            Util.Util.Title("Menú",ConsoleColor.Blue);
            
             Console.WriteLine("""
            seleccione alguna de las opciones:
            1:solicitudes
            2:inventario
            """);
            if (Userloged.Rolecheck())
            {
                
            Console.WriteLine("""
            Opciones de administrador:
            3: Empleados

            0:cerrarSesion
            """);
            AdminOptionSelector();

            }else
            {
            Console.WriteLine("0:cerrarSesion");
            OptionSelector();   
            }
            

        }
        private  void OptionSelector(){
            Console.WriteLine();
            Console.WriteLine("oprima el numeor de opcion");
            ConsoleKeyInfo key=Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Solicitud soli= new Solicitud();
                    soli.SoliMenu();
                    MainMenu();
                break;
                

                case ConsoleKey.D2:
                Inventario invView= new Inventario();
                invView.InvMenu();
                MainMenu();
                break;

                
                case ConsoleKey.D0:
                Util.Util.GreenText("Cerrando sesion");
                emC.SaveAllinFile(emC.FormatAll());

                List<string> cambios=cc.FormatAll(CambioController.Pendientes);
                cambios.AddRange(cc.FormatAll(CambioController.Completados));
                cc.SaveAllinFile(cambios);
                
                CreC.SaveAllinFile(CreC.FormatAll());
                Util.Util.GreenText("Todo guardado");

                Userloged= null;
                               
                break;
                
                default:
                Util.Util.RedText("opcion incorrecta");
                OptionSelector();
                break;
            }
        }
        private  void AdminOptionSelector(){
            Console.WriteLine();
            Console.WriteLine("oprima el numero de opcion");
            ConsoleKeyInfo key=Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                Solicitud slt=new Solicitud();
                slt.SoliMenu();
                MainMenu();
                break;

                case ConsoleKey.D2:
                Inventario invView= new Inventario();
                invView.InvMenu();
                MainMenu();
                break;

                case ConsoleKey.D3:
                Empleado emp= new Empleado();
                emp.Menu();
                MainMenu();

                break;
                case ConsoleKey.D0:
                Util.Util.GreenText("Cerrando sesion");
                emC.SaveAllinFile(emC.FormatAll());

                List<string> cambios=cc.FormatAll(CambioController.Pendientes);
                cambios.AddRange(cc.FormatAll(CambioController.Completados));
                cc.SaveAllinFile(cambios);

                CreC.SaveAllinFile(CreC.FormatAll());

                
                break;
                
                default:
                Util.Util.RedText("opcion incorrecta");
                AdminOptionSelector();
                break;
            }
        }

    }
}