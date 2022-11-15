using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Python tuile";
            int intNum = 3;
            double doubNum = 3.82;


            Printer.Print<string>(ref text);
            Printer.Print<int>(ref intNum);
            Printer.Print<double>(ref doubNum);
        }
    }
    class Printer
    {
        //your code goes here
        public static void Print<T>( ref T a){
            Console.WriteLine("Showing " + a);
        }
        
    }
}