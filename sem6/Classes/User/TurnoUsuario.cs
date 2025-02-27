using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sem6.Classes.LinkedList;
using sem6.Classes.Queue;
using sem6.Classes.Stack;

namespace sem6.Classes.User
{
    public class TurnoUsuario
    {
        private Queue.Queue registro;
        private Stack.Stack UsuariosAtendidos;
        public TurnoUsuario(){
            registro=new Classes.Queue.Queue();
            UsuariosAtendidos= new Classes.Stack.Stack();       
        }
        public void registrar(Empleado e){
            registro.Enqueue(e);
        }
        public Empleado atenderSiguiente(){
            Empleado e= (Empleado)registro.Dequeue();
            if (e == null)
            {
                Console.WriteLine("Lista vacia");
                return null;
            }
            UsuariosAtendidos.push(e);
            return (Empleado)registro.first();

        }
        public void AllToFile(){
            string route= "Out";
            Out.FileIO.SaveFile($@"{route}\resgistro.txt",QueInlist());
            Out.FileIO.SaveFile($@"{route}\Atencion.txt",StackInlist());
            
        }
        public void UploadFromFile(){
            List<string> Register= Out.FileIO.UploadFile($@"Out\resgistro.txt");

            List<string> Atention= Out.FileIO.UploadFile($@"Out\Atencion.txt");

            if (Register.Count!=0){
            foreach (string item in Register){

                registro.Enqueue(new Empleado(item));
            }
            }
            if ( Atention.Count!=0){
            foreach (string item in Atention){
                UsuariosAtendidos.push(new Empleado(item));
            }
            }
        }
        public List<string> QueInlist(){
        List<string> Data= new List<string>();
        Node node= registro.data.Cabeza;

            if(node != null){
             while (node!=null){
                Empleado cb= (Empleado)node.Valor;
               Data.Add(cb.ToString());
               node=node.Siguiente;
            }
            }
        return Data;
    }
        public List<string> StackInlist(){
        List<string> Data= new List<string>();
        Node node= UsuariosAtendidos.data.Cabeza;

            if(node != null){
             while (node!=null){
                Empleado cb= (Empleado)node.Valor;
               Data.Add(cb.ToString());
               node=node.Siguiente;
            }
            }
        return Data;
    }
        

        
        
    }
}