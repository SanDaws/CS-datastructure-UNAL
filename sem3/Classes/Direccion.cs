using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sem3.Classes;
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
    public Direccion(string format){
        string[] SplitFormat=format.Split("--");
        
        Calle = Convert.ToString(SplitFormat[0].Replace("_"," "));
        Nomenclatura = SplitFormat[1].Replace("_"," ");
        Barrio =SplitFormat[2].Replace("_"," ");
        Ciudad =SplitFormat[3].Replace("_"," ");
        Edificio =SplitFormat[4].Replace("_"," ");
        Apto = SplitFormat[5].Replace("_"," ");

    }

    public Direccion(string calle, string nomenclatura, string barrio, string ciudad, string edificio, string apto)
    {
        
        Calle = String.IsNullOrEmpty(calle)?"None":calle.Replace(" ","_");
        Nomenclatura = String.IsNullOrEmpty(nomenclatura)?"None":nomenclatura.Replace(" ","_");
        Barrio = String.IsNullOrEmpty(barrio)? "None":barrio.Replace(" ","_");
        Ciudad = String.IsNullOrEmpty(ciudad)? "None":ciudad.Replace(" ","_");
        Edificio = String.IsNullOrEmpty(edificio)?"None":edificio.Replace(" ","_");
        Apto = String.IsNullOrEmpty(apto)?"None":apto.Replace(" ","_");
    }

    public string Format(){
        return $@"{Calle}--{Nomenclatura}--{Barrio}--{Ciudad}--{Edificio}--{Apto}";
    }
}
