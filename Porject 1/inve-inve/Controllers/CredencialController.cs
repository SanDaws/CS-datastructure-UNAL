using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Data;
using inve_inve.Models;

namespace inve_inve.Controllers
{
    public class CredencialController
    {
        public static List<Credencial> Credentials= new List<Credencial>();
        public static readonly string route=@"Data\Password.txt";
        public CredencialController(){}


        //import all credentials
        public void LoadDatabase(){
            List<string> db= FileIO.UploadFile(route);
            foreach (string CredentialFormat in db){
                Console.WriteLine(CredentialFormat);
                Credentials.Add(new Credencial(CredentialFormat));
            }
        }

        //save all credentials 
        public void SaveAllinFile(List<string> formatedList){
            FileIO.SaveFile(route,formatedList);
        }
        // export to a string list
        public List<string> FormatAll(){
            List<string> db=new List<string>();
            foreach (Credencial credential in Credentials){
                db.Add(credential.ToString());
            }
            return db;
        }
            
        //create a credential
        //find in the same form as the employee creation
        public void CreateCredentials(string cedula, string pass){
            Credencial cre= new Credencial(cedula, pass);
            Credentials.Add(cre);
        }

        
        //Check for credential by document
        public Credencial Login(string cedula, string pass){
            Console.WriteLine(cedula);
            Credencial? cre=FindCredencial(cedula);
            if (cre != null)
            {
                if(cre.verifyPassword(pass)){return cre;}
            }
            return null;//user or password incorrect

        }
        public Credencial? FindCredencial(string cedula){
            foreach (Credencial item in Credentials)
            {
                if(item.Cedula== long.Parse(cedula)){
                    return item;
                }
            }
            return null;
        }
        public void DeleteCredentials(Credencial cre){
            if(cre != null){
                Credentials.Remove(cre);
            Util.Util.GreenText($@"{cre.Cedula} eliminado satiasfacoriamente");
            }
            else
            {
                Util.Util.RedText("Imposible eliminar");
            }
        }
        
    }
    
}