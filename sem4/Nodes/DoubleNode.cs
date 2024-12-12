using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem4.Nodes;
public class DoubleNode
{
    public int Valor;//cualqueir conjunto de valores
    public DoubleNode Siguiente;//indicador del siguiete nodo
    public DoubleNode Anterior;//indicador del anterior nodo

    public DoubleNode(int valor)//por defecto nunca hay un objeto siguite
    {
        Valor = valor;
        Siguiente = null;
        Anterior = null;
    }

}
