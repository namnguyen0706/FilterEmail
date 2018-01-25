using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace FilterEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string line ="";
                Regex pattern1 = new Regex(@"(.+)(@+)(gmail+)(\.+)(com)");
                // doc va ghi file
                StreamReader sr = new StreamReader(args[0]);
                StreamWriter sw = new StreamWriter("mail.txt");
                
                List<string> result = new List<string>();
                while(line!=null)
                {
                    result.Add(line);
                    line = sr.ReadLine();
                }
                
                foreach (var item in result)
                {
                    Match match = pattern1.Match(item);
                    if(match.Success)
                    sw.WriteLine(match);
                }
                sr.Close();
                sw.Close();
                //sw.close();
                }
                catch (Exception ex)
                {
                
                    System.Console.WriteLine(ex.Message);
                }
            
        
            
        }
    }
}
