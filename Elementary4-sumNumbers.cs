// Sums a given number 'n' from 1 to n
using System.IO;
using System;

class Program
{
    static void Main()
    {
        int n=0;
        while (n<=0){
            Console.WriteLine("Enter a number:");
            
            try
            {
                n=Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Number must be an integer greater than 0");
                
            }
        }
        
        int sum=0;
        for (int i=0; i<=n; i++){
            sum+=i;
        }
        Console.WriteLine("Sum is: {0}", sum);
        
    }
}