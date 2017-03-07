// prints multiplication tables for n, up to 12
using System.IO;
using System;

class Program
{   
    static public void printTables(int n)
    {
        //prints a table of the multiplication products
        // print a row of the multipliers
        string multipliersRow="        ";
        string multipliersUnderline="        ";
        for (int multiplier=1; multiplier<=n; multiplier++){
            multipliersRow+=String.Format("{0,-8}", multiplier);
            multipliersUnderline+=String.Format("{0,-8}", "---");
        }
        Console.WriteLine(multipliersRow);
        Console.WriteLine(multipliersUnderline);
        
        for (int i=1; i<=n; i++){
            // increment the columns
            string row=String.Format("{0,-5}{1,-3}", i, "|");  // print column of the multipliers
            for (int j=1; j<=n; j++){
                // increment the rows
                int product=j*i;
                row+=String.Format("{0,-8}", product);
            }
            Console.WriteLine(row);
        }
    }
    static void Main()
    {
        int number=0;
        
        // get user input until number is between 1 and 12
        while (number<1 || number>12){
            Console.WriteLine("Enter a number between 1 and 12 to recieve its multiplication table:");
            try{number=Convert.ToInt32(Console.ReadLine());}
            catch{Console.WriteLine("Number must be between 1 or 12.");}
        }
        printTables(number);
    }
}
