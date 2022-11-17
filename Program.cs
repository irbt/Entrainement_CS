using System;
using System.Collections.Generic;

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    SortedList<string, int> sl = new SortedList<string, int>();

		    sl.Add("Solo", 59);
		    sl.Add("A", 95);
		    sl.Add("Learn", 72);
		    //sl.Remove("A");
            
		    Console.WriteLine("Sorted List: ");
		    foreach (string s in sl.Keys)
		        Console.WriteLine(s + ": " + sl[s]);  // Learn: 72  Solo: 59
		    Console.WriteLine("\nCount: " + sl.Count);  // 2

            // ----------VALUES --------!
            Console.WriteLine("\nIndexed retrieval using the Values " +
                "property: Values[2] = {0}", sl.Values[2]);		
            
            
            if (sl.ContainsKey("A"))  {
                Console.WriteLine("Contient : A" );
            }
            
	}
}
}
