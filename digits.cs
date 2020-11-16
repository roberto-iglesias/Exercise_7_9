/*This program calculates how many numbers of 1, 2, 3 or more digits are
    entered by the user until he/she types “end”.*/

using System;

class digits
{
    static void Main()
    {
        int a = 0, b = 0, c = 0, d = 0;
        
        Console.Write("Insert a number: ");
        string input = Console.ReadLine(); 
        // Read the number as string to check the word "end"
        
        while (input != "end")
        {
            int number = Convert.ToInt32(input);
            
            if (input != 0)
            {
                if (number / 10 == 0)
                    a++;
                
                else if (number / 100 == 0)
		            b++;
                
                else if (number / 1000 == 0)
                    c++;
                
                else
                    d++;
                /* We could have used switch instead,
                but we decided to keep this program as
                simple as we could */
            }
            e = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", a, b, c, d); 
    }
}

