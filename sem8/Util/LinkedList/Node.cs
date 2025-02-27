using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sem6.Classes.LinkedList;
    public class Node
    {
        public object Valor;//cualqueir conjunto de valores
    public Node Siguiente;//indicador del siguiete nodo

    public Node(object valor)//por defecto nunca hay un objeto siguite
    {
        Valor = valor;
        Siguiente = null;
    }
    }
