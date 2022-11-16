using System;
using System.Collections.Generic;

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    List<int> li = new List<int>();
            li.Add(59);
            li.Add(72);
            li.Add(95);
            li.Add(5);
            li.Add(9);
            li.RemoveAt(1); // remove 72
            
            Console.Write("\nList: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 59  95  5  9
            li.Sort();
            //li.Clear();
            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 5  9  59  95
            
            int test = 77;

            //-------------------------------------------------------------
            li.Insert(2, test);
            li.Add(9);

            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 5  9  59  95
            // -------------------------------------------------
            li.Remove(9);
            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); 

            // -------------------------------------------------
            li.TrimExcess();
            //-------------------------------
            /*Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Entrez le numéro à chercher");
            int s =  Convert.ToInt32( Console.ReadLine());
            if (li.Contains(s)){
                Console.WriteLine("true");
            }else {
                Console.WriteLine("pas trouvé");

            };

            Console.WriteLine("----------------------------------------------");*/
            li.Insert(5, 977 );
            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); 

            li.Insert(6, 66 ); // plante si index>6
            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); 

		}
	}
}
