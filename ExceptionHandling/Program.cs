﻿using System;
class ExceptionDemo
{
    static void Main() 
    {

        try
        {  
            // system exception
            Console.WriteLine("Enter 1st no"); 
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no");

            int y = int.Parse(Console.ReadLine());

            int z = x / y;
            Console.WriteLine("The result is" + z);
        }
        catch (DivideByZeroException ex1)
        {
            Console.WriteLine(ex1.Message);
        }
        catch (FormatException ex2)
        {
            Console.WriteLine("Input must be numeric");  
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("End of the exception program");
    }
}

