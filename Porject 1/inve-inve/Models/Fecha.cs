using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inve_inve.Models;
public class Fecha{

    public short dd { get; set; }
    public short mm { get; set; }
    public short yy { get; set; }

    private Fecha(){}

    public Fecha(string format){
        string[] f=format.Split("-");
        dd = short.Parse(f[0]);
        mm = short.Parse(f[1]);
        yy = short.Parse(f[2]);

    }
    public Fecha(short dd, short mm, short yy)
    {
        this.dd = dd;
        this.mm = mm;
        this.yy = yy;
    }

    public override string ToString()
    {
        return $@"{dd}-{mm}-{yy}";
    }
    public static Fecha Now(){
        Fecha actual= new Fecha();
        actual.dd= (short)DateTime.Now.Day;
        actual.mm= (short)DateTime.Now.Month;
        actual.yy= (short)DateTime.Now.Year;
        return actual;
    }
}
