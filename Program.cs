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
            double discount = 10;

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here
           string [] names = new string [coffee.Count];
             
            foreach (string s in coffee.Keys){
                 names = coffee.Keys.ToArray();
            }
            
            double newprice ;

            foreach (string n in names)
            {
                //Console.WriteLine(coffee[n]) ;
                Console.Write(n+ ": " );
                newprice = coffee[n] * (1-(discount/100));
                Console.WriteLine(newprice) ;

            }



            /*for( int i = 0 ; i < names.Length ; i++ ){
                coffee
            }*/
            



        }
    }
}