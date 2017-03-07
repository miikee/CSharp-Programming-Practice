//Write a function that computes the running total of a list.
using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static double addList(List<double> list, double addition){
  	// add to the list and sum it
    list.Add(addition);
    
    // return list.Sum();  // too easy, build a function to sum the list together instead
    double sum=0;
    foreach(double item in list){
      sum+=item;
    }
    return sum;
    
  }
     
  public static void Main()
  {
		// computes the running total of a list
    List<double> list = new List<double>();
    string input="";  // user in input
    double dblInput=0;
    double sum=0; // sum of the list
     
    Console.WriteLine("This program computes the running total of a list.");

    
    while(input!="x"){
    	Console.WriteLine("Please enter the next item ('x' to exit):");
      input=Console.ReadLine();
      
      if (input=="x"){// exit on "x"
        Console.WriteLine("Final Total: {0}", sum);
        Console.WriteLine("Program exitted.");
        break;
      }  
      
      // validate inpute
      if(!double.TryParse(input, out dblInput)){
        Console.WriteLine("Please enter an integer or decimal.");
        continue;
      } 
      
      // add to the list and sum it
      sum=addList(list, dblInput);
      Console.WriteLine("Total: {0}", sum);
    }
  }
}
