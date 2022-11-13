using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player(Difficulty.Easy);
            Player player2 = new Player(Difficulty.Medium);
            Player player3 = new Player(Difficulty.Hard);
        }
    }
    
    /*
    Easy => "You have 3 minutes 45 seconds"
    Medium = > "You have 3 minutes 20 seconds"
    Hard => "You have 3 minutes"
    */

    class Player
    {
        public Player(Difficulty x)
        {
            //your code goes here
            //Difficulty.x = Difficulty.Easy;
            
            //int x = (int) di ;


            switch (x) {
                case  Difficulty.Easy:
                Console.WriteLine("You have 3 minutes 45 seconds");
                break ;
                case  Difficulty.Medium:
                Console.WriteLine("You have 3 minutes 20 seconds");
                break ;
                case  Difficulty.Hard:
                Console.WriteLine("You have 3 minutes");
                break ;
            }
            
        }
    }
     enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };
}