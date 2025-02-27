using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem8.classes
{
    public class Per_sona
    {
        public string Nombre{get;set;}
        public int Identificacion{get;set;}
        public int key{get;set;}

        public Per_sona(string Nombre, string id){
            this.Nombre=Nombre;
            Identificacion= int.Parse(id);
            key=cont(id);
        }
        public int cont(string i){
            int c=0;
            foreach (string item in i.Split())
            {
                c += int.Parse(item);     
            }
            return c;
        }
        public override string ToString()
        {
            return $@"
                nombre:{Nombre}
                documento: {Identificacion}
                llave: {key}
            ";
        }
    }
}