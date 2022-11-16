using System;
using System.Collections.Generic;

namespace SoloLearn
{
    /*You need to write a program for the game to sort player scores.
The program you are given takes N number as input, which represents the number of players, and defines a score list.
Complete the program to take N count of numbers (the scores) as input, store them in a scores list, sort and output them, each separated by a space.*/
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());

            List<int> scores = new List<int>();
            int count = 0;
            while (count<numOfPlayers)
            {
                int score = Convert.ToInt32(Console.ReadLine());
                //your code goes here
                
            }

            //sort the list and output elements
            
        }
    }
}
