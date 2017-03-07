// program prints the next 20 leap years
// leap year if divisible by 4
// if it is a century year (divisible by 100) and not divisble by 400, then skip it
using System.IO;
using System;
using System.Collections.Generic;

class Program
{   
    static void Main(){
        DateTime now= DateTime.Today;
        
        int year=Convert.ToInt32(now.Year);
        int count=0;
        
        while(count<20){
            
            if(year%4==0){
                // if it is a century year, and is not divisible by 400, then skip it
                if (year%100==0){
                    year++;
                    continue;
                }
                Console.WriteLine(year);
                count++;
            }
            year++;
        }
    
    }
}
