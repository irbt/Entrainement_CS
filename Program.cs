using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Some text";
            File.WriteAllText("test.txt", str);
            
            string txt = File.ReadAllText("test.txt");
            Console.WriteLine(txt); 

            string add = "added text";
             

            
            File.AppendAllText ("test.txt",add);
            
            string txt2 = File.ReadAllText("test.txt");
            Console.WriteLine(txt2); 

            if ( File.Exists ("test.txt")){
              Console.WriteLine("le fichier existe");
            }

        }
    }
}