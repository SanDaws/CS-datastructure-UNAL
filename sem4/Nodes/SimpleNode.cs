using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem4.Nodes;
public class SimpleNode
{
    public int Valor;//cualqueir conjunto de valores
    public SimpleNode Siguiente;//indicador del siguiete nodo

    public SimpleNode(int valor)//por defecto nunca hay un objeto siguite
    {
        Valor = valor;
        Siguiente = null;
    }

}
