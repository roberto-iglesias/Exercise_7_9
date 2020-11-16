/* This program calculates the average of a set of marks, 
	until the user types "end" */

using System;

public class Average
{
	public static void Main()
	{
		double sum = 0, mark, c = 0, average;
		string exit; // We use "string" to read if the user types "end".
		
		Console.Write("Insert a mark: ");
		exit = Console.ReadLine(); 
		
		while (exit != "end")
		{ 
			mark = Convert.ToDouble(exit);
			c++;
			sum += mark; 
			
			Console.Write("Insert a mark: ");
			exit = Console.ReadLine();
		}
		
		if (c != 0)
		{
			average = sum / c;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
