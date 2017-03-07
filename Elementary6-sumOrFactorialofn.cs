// Gives sum or factorial for a given number 'n' from 1 to n
// Users choice to sum or factorial
using System.IO;
using System;

class Program
{   
    public static long sum(int n){
        long sum=0;
        for (int i=0; i<=n; i++){
            sum+=i;
        }
        return sum;
    }
    public static long factorial(int n){
        long factorial=1;
        for (int i=1; i<=n; i++){
            factorial*=i;
        }
        return factorial;
    }
    static void Main()
    {
        int n=0;
        while (n<=0){
            Console.WriteLine("Enter a number:");
            
            try{
                n=Convert.ToInt32(Console.ReadLine());
            }
            catch{
                Console.WriteLine("Number must be an integer greater than 0");
            }
        }
        int selection=0;
        while (selection!=1 && selection!=2){
            Console.WriteLine("Please select (1)Sum or (2)Factorial:");
            try{
                selection=Convert.ToInt32(Console.ReadLine());
            }
            catch{
                Console.WriteLine("Selection must be either 1 or 2");
            }
        }
        
        long answer;
        switch(selection){
            case(1):
                answer=sum(n);
                break;
            case(2):
                answer=factorial(n);
                break;
            default:
                answer=0;
                break;
            
        }
        Console.WriteLine("Answer is: {0}", answer);
        
    }
}
