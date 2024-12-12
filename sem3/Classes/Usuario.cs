using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sem3.Classes;
public class Usuario{
    //C# by itself  cant generate a accesor and a mutator  that have different
    // in the lastest versions of .net the Get and set where put in thsi way to avoid all the syntax
    public long Id{get;set;}
    public string? Nombre{get;set;}
    public Fecha? Fecha{get;set;}
    public string? CiudadNacimeinto{get;set;}
    //i may think by experience is better to use String for this kind of text becuase we don going to make operation whit this one
    public long Tel{get;set;}
    public string? Email{get;set;}
    public Direccion? Dir{get;set;}

    public Usuario(){}

    public Usuario(long id,string nombre,  Fecha fecha, string ciudadNacimeinto, long tel, string email, Direccion dir)
    {
        Nombre = nombre;
        Id = id;
        Fecha = fecha;
        CiudadNacimeinto = ciudadNacimeinto;
        Tel = tel;
        Email = email;
        Dir = dir;
    }
    public string Format(){
        return $@"{Id} {Nombre} {CiudadNacimeinto} {Tel} {Email} {Fecha.Format()} {Dir.Format()}";
    }

}
