using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sem2.src
{
    public class Fecha
    {

        public short dd{get;set;}
        public short mm{get;set;}
        public short yy{get;set;}

        public Fecha(short dd, short mm, short yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }

        public string Format(){
            return $@"{dd}-{mm}-{yy}";
        }
    }
}