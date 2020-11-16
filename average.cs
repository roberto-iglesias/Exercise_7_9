using System;

public class Average
{
	public static void Main()
	{
		double sum=0, mark, c=0, average;
		string exit;
		
		Console.Write("Insert a mark: ");
		exit=Console.ReadLine();	// we read the mark as string to check the word "end"	 
		
		while(exit!="end")
		{  // if the mark isn't an end then we pass it to double to work with it
			mark=Convert.ToDouble(exit);
			c++;   //counter of numbers
			sum+=mark;  // sum of all the notes
			Console.Write("Insert a mark: ");
			exit=Console.ReadLine();
		}
		
		if(c!=0)
		{
			average=sum/c;  //calculate the average
			Console.WriteLine("The average is {0}.",average);
		}
	}
}
