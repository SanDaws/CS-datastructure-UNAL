using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Controllers;
using inve_inve.Data;
using inve_inve.Models;

namespace inve_inve.Views;
public class Inventario
{
    EmpleadoController ec;
    EquipoController equipoController;
    public Inventario()
    {
        ec = new EmpleadoController();
        equipoController = new EquipoController();
    }
    public void InvMenu(){
        Util.Util.Title("Inventario", ConsoleColor.DarkYellow);

        Console.WriteLine("""
            seleccione alguna de las opciones:
            1: Mi inventario
            """);
            if (Menu.Userloged.Rolecheck())
            {
                
            Console.WriteLine("""
            Opciones de administrador:
            2: inventario general
            3: inventario de empleado

            0:Volver
            """);
            AdminOptionSelector();

            }else
            {
            Console.WriteLine("0:Volver");
            OptionSelector();   
            }
            
    }
    private void OptionSelector(){
        Console.WriteLine("oprima el numeor de opcion");
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D1:
                invPersonal();
                InvMenu();
                break;

            case ConsoleKey.D0:break;

            default:
                Console.WriteLine("opcion incorrecta");
                OptionSelector();
                break;
        }

    }
    private void AdminOptionSelector(){
        Console.WriteLine("oprima el numeor de opcion");
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D1:
                invPersonal();
                InvMenu();
                break;
            case ConsoleKey.D2:
                invGeneral();
                InvMenu();
                break;
            case ConsoleKey.D3:
                invbyID();
                InvMenu();
                break;
            case ConsoleKey.D0:break;

            default:
                Console.WriteLine("opcion incorrecta");
                OptionSelector();
                break;
        }
    }
    //inventario general  y opocoiun de imprimir en archivo
    public void invGeneral(){
        Util.Util.Title("inventario general",ConsoleColor.Blue);
        Console.WriteLine($"{"Placa",-12}|{"Nombre",-20}|{"Fecha",-20}|{"Precio",-15}");
        List<Equipo> equ=equipoController.AllEquipos();
        foreach (Equipo item in equ){
                Console.WriteLine($@"{item.Placa,12}{item.Nombre,20}{item.Fecha,20}{item.Precio,15:c}");
            }
        Console.WriteLine("Desea importarlo a archivo?(Y/N): ");
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.Y:
                List<string> trs=equipoController.FormatAll(equ);
                FileIO.SaveFile(@"Out\inventario_general.txt",trs);

                break;
            case ConsoleKey.N: break;

            default:
                Console.WriteLine("opcion incorrecta, volviendo al menu");
                break;
        }
    }
    //inventario individual y opocoiun de imprimir en archivo
    public void invPersonal(){
        Models.Empleado emp= ec.FindEmploye(Menu.Userloged.Cedula);
        Util.Util.Title("Mi inventario",ConsoleColor.DarkYellow);

        equipoController.PrintLista(emp);
        
        Console.WriteLine("Desea importarlo a archivo?(Y/N): ");
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.Y:
                ec.SaveinFile(emp);
                break;
            case ConsoleKey.N: break;

            default:
                Console.WriteLine("opcion incorrecta, volviendo al menu");
                break;
        }
    }
    public void invbyID(){
        long id= Util.Exceptions.safeInt("Cedula del empleado");
        Models.Empleado? emp= ec.FindEmploye(id);
    if (emp != null)
    {
        equipoController.PrintLista(emp);
        Console.WriteLine("Desea importarlo a archivo?(Y/N): ");
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.Y:
                ec.SaveinFile(emp);
                break;
            case ConsoleKey.N: break;

            default:
                Console.WriteLine("opcion incorrecta, volviendo al menu");
                break;
        }
    }
    else
    {
        Util.Util.RedText("Usuario no encontrado");
    }
    }


}