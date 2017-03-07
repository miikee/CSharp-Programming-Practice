// User tries to guess random number
// Program responds too small or too large
// each unique guess counts as one guess
using System.IO;
using System;
using System.Collections.Generic;

class Program
{   
    public static bool check(int guess, int number){
        if(guess==number){
            return true;
        }
        else if(guess>number){
            Console.WriteLine("You guessed too high");
            return false;
        }
        else{
            Console.WriteLine("You guessed too low");
            return false;
        }
    }
    
    public static int guessCount(int guess, List<int> guesses){
        // if guess is unique add it to list of guesses
        if(!guesses.Contains(guess)){
            guesses.Add(guess);
        }
        
        return guesses.Count;
    }
    
    static void Main()
    {
        bool correct=false;
        int guess=5000; // guess out of range, sure to be false
        List<int> guessedNumbers=new List<int>();
        Random random= new Random();
        int number=random.Next(0,500);  // random number to be guessed
        int guessCounter=0;
        
        Console.WriteLine("Guess the number.");
        
       
        while(!correct){
            
            Console.WriteLine("Guess a number between 0 and 500:");
            var input=Console.ReadLine();
            if(!int.TryParse(input, out guess)){
                Console.WriteLine("Guess must be a number between 0 and 500");
                break;
            }
            
            guessCounter=guessCount(guess, guessedNumbers);
            if(check(guess, number)){
                correct=true;
            }
            else{
                
                Console.WriteLine("Guess number {0} was wrong.", guessCounter);
            }
        }
        Console.WriteLine("Congratulations, {0} was the number.", guess);
        Console.WriteLine("You guessed the number in {0} guesses.", guessCounter);
    }
}
