using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez nb de score");
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine ("nb players = " + numOfPlayers);

            List<int> scores = new List<int>();
            int count = 0;
            while (count < numOfPlayers)
            {
                Console.WriteLine("Entrez un score");

                int score = Convert.ToInt32(Console.ReadLine());
                //your code goes here
                //Console.WriteLine("Boucle avant incr " + count);
                scores.Add(score);
               //Console.WriteLine(scores[count]);
                count++;
                //Console.WriteLine("Boucle après incr " + count);
                
            }

            //sort the list and output elements
            scores.Sort();
            
            
            for (int i=0 ; i < count ; i++){
                Console.Write ( scores [i] + " ");
                
            }
            
        }
    }
}
