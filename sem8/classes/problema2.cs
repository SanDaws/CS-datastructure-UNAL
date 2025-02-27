using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sem8.Util;

namespace sem8.classes;
    public class problema2:Problema1
    {
        public problema2(){
        }
        public void newdato(){
            
            Console.WriteLine("NUEVO INGRESO");
            Console.WriteLine("nuevo Nombre");
            string? dato= Console.ReadLine();
            Console.WriteLine("nueva Documento");
            string clave= Console.ReadLine();
            Per_sona zona= new Per_sona(dato,clave);

            bst.insert(dato,zona.key); 

        }
    }
