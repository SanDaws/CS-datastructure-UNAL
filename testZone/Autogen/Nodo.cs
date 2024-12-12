using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testZone.Autogen
{
    class Nodo{ //base nodo para una lista
    public int Valor;//cualqueir conjunto de valores
    public Nodo Siguiente;//indicador del siguiete nodo

    public Nodo(int valor)//por defecto nunca hay un objeto siguite
    {
        Valor = valor;
        Siguiente = null;
    }
}
}