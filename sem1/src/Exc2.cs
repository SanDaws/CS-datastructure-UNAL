using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace sem1.src;
public static class Exc2{
    static readonly string routes = @"Public\test_pr2.txt";
    public static void Solution(){
        Console.WriteLine("------------------Ejercicio2-------------");
        string lookingFor = @"(?<=^|\s)en(?=\s)";
        using (StreamReader file = File.OpenText(routes))
        {
            string line;
            int count = 0;
            int linesReaded = 0;
            while ((line = file.ReadLine()) is not null){
                linesReaded++;
                MatchCollection match = Regex.Matches(line.ToLower(), lookingFor);
                count += match.Count>0 ? match.Count : 0;
            }
            
    Console.WriteLine($@"
    lines readed: {linesReaded}
    'en' found: {count}");


        }
    }
}
