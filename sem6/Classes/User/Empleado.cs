using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem6.Classes.User
{
    public class Empleado: User{
        public Empleado(long id, string Nombre){
            Id= id;
            this.Nombre= Nombre;
        }
        public Empleado( string Format){
            string[] a= Format.Split("-");
            Nombre= a[0];
            Id= Int64.Parse(a[1]);
        }
        public override string ToString(){
            return $@"{Nombre}-{Id}";

        }
        
        
    }
}