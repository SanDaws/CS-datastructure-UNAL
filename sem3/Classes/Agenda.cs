using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sem3.Classes;

namespace sem3.Classes;
public class Agenda{
    string filePath = @"Public\agenda.txt";
    private Usuario[] Registro;
    private int noReg=0;
    public Agenda(int capacity){
        Registro = new Usuario[capacity];
        
    }
    public Usuario[] getRegistros(){
        return Registro;
    }
    public bool Agregar(Usuario U){
        int response= Buscar(U.Id);
        if (response != -1 && noReg<Registro.Length){
            Registro[noReg]= U;
            noReg ++;
            return true;
        }

        return false;
    }
    public int Buscar(long id){
        if (id > Registro.Length -1){
        return -1;
        }
        for (int i = 0; i < Registro.Length; i++){
            bool ida = Registro[i].Id == id;
            int index = Registro.Length - 1 - i;
            bool vuelta = Registro[index].Id == id;
            if (index == i && !ida && !vuelta){
                return -1;
            }
            if (ida)
            {
                return i;
            }
            if (vuelta)
            {
                return index;
            }
        }
        return -1;
    }
    public bool Eliminar(long id){
        int response= Buscar(id);

        if (response != -1 && noReg<Registro.Length){
            Registro[response]= null ;
            noReg --;
            return true;
        }

        return false;
    }
    public Usuario show(int index){
        return Registro[index];

    }
    public void ToFile(){

        try
        {
            if (File.Exists(filePath))
            {

                foreach (Usuario user in Registro)
                {
                    string content= user.Format();
                File.AppendAllText(filePath, content);
                }

                Console.WriteLine("El contenido se ha escrito exitosamente.");
            }
            else
            {
                Console.WriteLine("El archivo especificado no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Imposible : {ex.Message}");
        }
    }

    
    public void Import(){
       using (StreamReader file = File.OpenText(filePath))
        {
            int lineCount = File.ReadAllLines(filePath).Length;
            Agenda Agenda= new Agenda(lineCount);
            string line;
            
            while ((line = file.ReadLine()) is not null){
                string[] data= line.Split();
                Fecha FechaObj= new Fecha(data[5]);
                Direccion Dir= new Direccion(data[6]);

                Usuario user= new Usuario(long.Parse(data[0]),
                data[1],
                FechaObj,
                data[2],
                long.Parse(data[3]),
                data[4],
                Dir);
                Agenda.Agregar(user);
             
            }

            
        }
    }
}
