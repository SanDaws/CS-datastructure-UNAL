using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem6.Classes.User;
public class User
{
public long Id{get;set;}
public string? Nombre{get;set;}
public Fecha? Fecha{get;set;}
public string? CiudadNacimiento{get;set;}
//i may think by experience is better to use String for this kind of text becuase we don going to make operation whit this one
public long Tel{get;set;}
public string? Email{get;set;}
public Direccion? Dir{get;set;}

}
