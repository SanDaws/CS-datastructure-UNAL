using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace sem1.src;
public static class Exc2{
    static readonly string routes = @"Public\test_pr2.txt";
    public static void Solution(){
        string lookingFor = @"\ben\b";
        using (StreamReader file = File.OpenText(routes))
        {
            string line;
            int count = 0;
            int linesReaded = 0;
            while ((line = file.ReadLine()) is not null){
                linesReaded++;
                Match match = Regex.Match(line.ToLower(), lookingFor);
                count += (match.Success is true) ? 1 : 0;
            }
            
            Console.WriteLine($@"
            lines readed: {linesReaded}
            'en' found: {count}:
            ");


        }
    }
}
