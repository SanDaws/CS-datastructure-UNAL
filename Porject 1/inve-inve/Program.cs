using inve_inve.Controllers;
using inve_inve.Models;
using inve_inve.Util;
using inve_inve.Views;

namespace inve_inve;

class Program
{
    static void Main(string[] args)
    {
        EmpleadoController em= new EmpleadoController();
        CambioController cc= new CambioController();
        CredencialController cd= new CredencialController();
        em.LoadDatabase();
        cc.LoadDatabase();
        cd.LoadDatabase();
        


        Login loged=new Login();
        Credencial logeduser= loged.LoginForm();//login

        Menu menu= new Menu(logeduser);
        menu.MainMenu();



        
    }
}
