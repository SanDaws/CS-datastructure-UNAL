using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem8.Util
{
    public class BSTEntry
    {
        public object data{get;set;}
        public int Key{get;set;}

        public BSTEntry(object data, int Key)
        {
            this.data = data;
            this.Key = Key;
        }
        public override string ToString()
        {
            return $@"Data: {data.ToString()} key: {Key}";
        }
    }
}