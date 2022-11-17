using System;
using System.Collections.Generic;

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    Stack<int> s = new Stack<int>();
            
		    s.Push(59);
		    s.Push(72);
		    s.Push(65);

		    Console.Write("Stack: ");
		    foreach (int i in s)
		        Console.Write(i + " ");  // 65  72  59
		    Console.Write("\nCount: " + s.Count);  // 3
            
		    Console.Write("\nTop: " + s.Peek());  // 65
		    Console.Write("\nPop: " + s.Pop());  // 65
            
		    Console.Write("\nStack: ");
		    foreach (int i in s)
		        Console.Write(i + " ");  // 72  59
		    Console.Write("\nCount: " + s.Count);  // 2
		}
	}
}
