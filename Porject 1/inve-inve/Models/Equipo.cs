using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace inve_inve.Models
{
    public class Equipo
    {
        public string Placa{get;set;}
        public string Nombre{get;set;}
        public Fecha Fecha{get;set;}//fecha de compra
        public int Precio{get;set;}
        public Equipo(string nombre,string placa,Fecha Fecha,int precio){
            Nombre=nombre;
            Placa=placa;
            this.Fecha=Fecha;
            Precio=precio;

        }
        public Equipo(string nombre,int precio){
            Nombre=nombre;
            Precio=precio;
        }
        public Equipo(string Format){// decript from file
            string[] Obj= Format.Split("/");
            Nombre=Obj[0];
            Placa=Obj[1];
            Fecha=new Fecha(Obj[3]);
            Precio=int.Parse(Obj[2]);

        }
        public static List<Equipo> ImportFromFile(string arr){
            List<Equipo> equipos= new List<Equipo>();
            string[] objects= arr.Split(",");
            
            foreach (string item in objects){
                equipos.Add(new Equipo(item));                
            }           
            return equipos;

        }
        public override string ToString()
        {
            return $@"{Placa}/{Nombre}/{Precio}/{Fecha.ToString()}";
        }
    }
}