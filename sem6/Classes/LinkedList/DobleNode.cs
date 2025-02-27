using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem6.Classes.LinkedList;
public class DobleNode{
    public object Valor;//cualqueir conjunto de valores
    public DobleNode Siguiente;//indicador del siguiete nodo
    public DobleNode Anterior;

    public DobleNode(object valor)//por defecto nunca hay un objeto siguite
    {
        Valor = valor;
    }
}
