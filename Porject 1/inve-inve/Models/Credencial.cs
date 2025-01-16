using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace inve_inve.Models;
public class Credencial
{
    public long Cedula { get; set; }
    private string Pass { get; set; }
    private Role Role { get; set; }
    private Credencial() { }
    public Credencial(string cedula, string pass){
        Cedula = long.Parse(cedula);
        Pass = pass;
        Role = Role.INVESTIGADOR;
    }
    public Credencial(string Format){
        string[] obj = Format.Split(":");
        Cedula = long.Parse(obj[0]);
        Pass = obj[1];
        Role = (obj[2]=="ADMINISTRADOR")?Role.ADMINISTRADOR:Role.ADMINISTRADOR;

    }
    public bool verifyPassword(string pss){
        return pss == Pass; 
    }

    public override string ToString(){
        return $@"{Cedula}:{Pass}:{Role}";
    }
    public bool Rolecheck()
    {
        if (Role != Role.ADMINISTRADOR)
        {
            return true;
        }
        return false;
    }

}
