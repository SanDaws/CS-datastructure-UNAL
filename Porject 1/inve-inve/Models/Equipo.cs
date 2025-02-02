using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace inve_inve.Models
{
    public class Equipo
    {
        public int Placa{get;set;}
        public string Nombre{get;set;}
        public Fecha Fecha{get;set;}//fecha de compra
        public int Precio{get;set;}
        public Equipo(string nombre,int placa,Fecha Fecha,int precio){
            Nombre=nombre;
            Placa=placa;
            this.Fecha=Fecha;
            Precio=precio;

        }
        public Equipo(string nombre,int precio){
            Nombre=nombre;
            Precio=precio;
            Fecha= Fecha.Now();
        }
        public Equipo(string Format){// decript from file
            string[] Obj= Format.Split("/");
            Placa=int.Parse(Obj[0]);
            Nombre=Obj[1];
            Precio=int.Parse(Obj[2]);
            Fecha=new Fecha(Obj[3]);

        }
        public static List<Equipo> ImportFromFile(string arr){
            List<Equipo> equipos= new List<Equipo>();
            string[] objects= arr.Split(",");
            Console.WriteLine(string.IsNullOrEmpty(objects[0]));
            if(!string.IsNullOrEmpty(objects[0])){
                foreach (string item in objects){
                equipos.Add(new Equipo(item));                
            }     }      
            return equipos;

        }
        public override string ToString()
        {
            return $@"{Placa}/{Nombre}/{Precio}/{Fecha.ToString()}";
        }
    }
}