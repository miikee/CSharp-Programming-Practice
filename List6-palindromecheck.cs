//Write a function that tests whether a string is a palindrome.
using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static bool testPalindrome(string text){
		text=text.ToLower();
    if (text==reverseString(text)){return true;}
    else return false;
  }
	public static string reverseString(string text){
  	// can use string function .ToCharArray... but making it difficult for learning
    char[] reverseArray= new char[text.Length];
    int j=0; // iterate through array
    string reverse;

    for(int i=text.Length-1; i>=0; i--){
      reverseArray[j]=text[i];
      j++;
    }
   	reverse=new string(reverseArray);  // condenses array into string
    return reverse;
	}
     
  public static void Main()
  {
    string input="";
		Console.WriteLine("Program checks if a function is a palindrome.");
    while(input!="x"){
    	Console.WriteLine("Please enter a string('x' to exit):");
  		input=Console.ReadLine();
      if(input=="x") break; // exit
      if(testPalindrome(input)){
        Console.WriteLine("{0} is a Palindrome.", input);
      }
      else{
        Console.WriteLine("{0} is NOT a Palindrome.", input);
      }
    }
    Console.WriteLine("Program Exitted.");
  }
}
