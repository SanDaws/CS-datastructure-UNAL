using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace inve_inve.Models;
public class Empleado{
    //C# by itself  cant generate a accesor and a mutator  that have different
    // in the lastest versions of .net the Get and set where put in thsi way to avoid all the syntax
    public long Id{get;set;}
    public string? Nombre{get;set;}
    public Fecha? Fecha{get;set;}
    public string? CiudadNacimiento{get;set;}
    //i may think by experience is better to use String for this kind of text becuase we don going to make operation whit this one
    public long Tel{get;set;}
    public string? Email{get;set;}
    public Direccion? Dir{get;set;}
    
    //almost a foreing key
    public List<Equipo> Inventario;
    

    private Empleado(){}
    public Empleado(string format){
        string[] obj= format.Split(":");
        Id = int.Parse(obj[0]);
        Nombre =obj[1].Replace("."," ");
        CiudadNacimiento = obj[2];
        Tel = long.Parse(obj[3]);
        Email = obj[4];
        Fecha = new Fecha(obj[5]);
        Dir = new Direccion(obj[6]);
        Inventario= Equipo.ImportFromFile(obj[7]);
    }

    public Empleado(long id,string nombre,  Fecha fecha, string ciudadNacimeinto, long tel, string email, Direccion dir)
    {
        Nombre = nombre.Replace(" ",".");
        Id = id;
        Fecha = fecha;
        CiudadNacimiento = ciudadNacimeinto;
        Tel = tel;
        Email = email;
        Dir = dir;
        Inventario=new List<Equipo>();
    }
    public override string ToString(){
        return $@"{Id}:{Nombre}:{CiudadNacimiento}:{Tel}:{Email}:{Fecha.ToString()}:{Dir.ToString()}:{string.Join(",",Inventario)}";
    }

}
