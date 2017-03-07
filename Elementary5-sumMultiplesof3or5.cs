// Sums a given number 'n' from 1 to n
// But it only sums multiples of 3 or 5
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
            if(i%3!=0 && i%5!=0) continue;  // skip addition if numbers not a multiple of 3 or 5
            sum+=i;
        }
        Console.WriteLine("Sum is: {0}", sum);
        
    }
}
