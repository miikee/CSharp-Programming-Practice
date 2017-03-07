// prints prime numbers up to n (max: 500)
using System.IO;
using System;

class Program
{   
    public static void printPrimes(int n){
        int primeCount=0;
        for (int i=1; i<=n; i++){
            bool isPrime=true;
            for (int j=1; j<=i; j++){
                if(j==1 || j==i){
                    // skip itself and 1
                    continue;
                }
                if(i%j==0){
                    isPrime=false; // disproves prime; if divisble by another number
                    break;
                }
            }
            if (isPrime){
                Console.WriteLine(i); // print n if prime
                primeCount++;
            }
        }
        double percent=Convert.ToDouble(primeCount)/n*100;
        Console.WriteLine("{0} prime(s) found.  {1:N2}% of the numbers were prime.", primeCount, percent);
    }
    static void Main()
    {
        int number=0;
        
        // get user input until number is between 1 and 12
        while (number<1 || number>5000){
            Console.WriteLine("Enter a number between 1 and 5000 to recieve all the prime numbers");
            try{number=Convert.ToInt32(Console.ReadLine());}
            catch{Console.WriteLine("Number must be between 1 or 5000.");}
        }
        printPrimes(number);
    }
}
