using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

                Console.WriteLine("Entrez 3 nombres");
            while (q.Count<3)
            {
                Console.WriteLine("Chiffre n°" + (q.Count+1));
                int num = Convert.ToInt32(Console.ReadLine());
                //your code goes here
                q.Enqueue(num);
                
            }

            Console.Write("Queue: ");
            foreach (int i in q){
                Console.Write(i + " ");}

            Console.WriteLine();
            
            Console.Write("Sorted: ");
            //your code goes here
            int [] arr = q.ToArray();
            Array.Sort(arr);
            
            foreach (int j in arr){
                Console.Write(j + " ");}
        }
    }
}