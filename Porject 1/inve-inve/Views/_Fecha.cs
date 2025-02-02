using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Models;

namespace inve_inve.Views
{
    public class _Fecha
    {
        public static Fecha FechaForm(){
            byte dd= Util.Exceptions.SafeByte("Dia");
            byte mm= Util.Exceptions.SafeByte("Mes");
            byte aa= Util.Exceptions.SafeByte("Año");
             
            return new Fecha(dd,mm,aa);;
            
        }
    }
}