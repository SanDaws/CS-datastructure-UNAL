using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace sem1.src;

/* 
Variables, expresiones y estructuras de control: Diseñe un programa que le pida al usuario
ingresar n números enteros, donde n también es ingresado por el usuario. El programa debe calcular (i) el valor
máximo, (ii) el valor mínimo, (iii) la suma de los enteros ingresados y (iv) el valor promedio.
*/
public static class Exc1{
    public static void Solution(){
        int total=0,
        min=0,
        max=0;

        Console.Write("inserte cantidad de numeros");
        int indexer= int.Parse(Console.ReadLine()); 
        for (int i = 0; i < indexer; i++)
        {
            Console.Write("inserte numero");
            int temp= int.Parse(Console.ReadLine());
            max=(temp> max)?temp:max;
            min = (temp<min || i == 1)? temp : min;
            total+= temp;
        }
        Console.WriteLine($@"
        total: {total}
        maximo: {max}
        mininmo: {min}
        promedio: {total/indexer:g}
        ");
        
        



    }


}
