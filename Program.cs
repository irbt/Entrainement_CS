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
            double doubNum = 3.8;


            Printer.Print<string>(ref text);
            Printer.Print<int>(ref intNum);
            Printer.Print<double>(ref doubNum);
            Printer.Print<double , int>(ref doubNum , ref intNum);
        }
    }
    class Printer
    {
        //your code goes here
        public static void Print<T>( ref T a){
            Console.WriteLine("Showing " + a);
        }
        
        public static void Print<T , U>( ref T a , ref U b){
            Console.WriteLine("Showing " + a + " + " + b);
    }
}
}