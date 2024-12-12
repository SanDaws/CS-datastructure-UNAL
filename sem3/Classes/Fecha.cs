using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sem3.Classes;
public class Fecha{

    public short dd { get; set; }
    public short mm { get; set; }
    public short yy { get; set; }

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

    public string Format()
    {
        return $@"{dd}-{mm}-{yy}";
    }
}
