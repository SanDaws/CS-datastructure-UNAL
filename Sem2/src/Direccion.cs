using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sem2.src;
public class Direccion
{
    public string? Calle { get; set; }
    public string? Nomenclatura { get; set; }
    public string? Barrio { get; set; }
    public string? Ciudad { get; set; }
    public string? Edificio { get; set; }
    public string? Apto { get; set; }
    public Direccion()
    {
    }

    public Direccion(string calle, string nomenclatura, string barrio, string ciudad, string edificio, string apto)
    {
        
        Calle = String.IsNullOrEmpty(calle)?"None":calle;
        Nomenclatura = String.IsNullOrEmpty(nomenclatura)?"None":nomenclatura;
        Barrio = String.IsNullOrEmpty(barrio)? "None":barrio;
        Ciudad = String.IsNullOrEmpty(ciudad)? "None":ciudad;
        Edificio = String.IsNullOrEmpty(edificio)?"None":edificio;
        Apto = String.IsNullOrEmpty(apto)?"None":apto;
    }

    public string Format(){
        return $@"{Calle} {Nomenclatura} {Barrio} {Ciudad} {Edificio} {Apto}";
    }
}
