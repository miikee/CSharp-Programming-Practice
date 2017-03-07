// Write a function on_all that applies a function to every element of a list. 
// Use it to print the first twenty perfect squares 
// (a natural number n is a perfect square if it can be written as n=m*m 
// for some other natural number m. 1,4,9,16,25 are the first 5).

// Little confusing, so I did it the way I thought its taking about
// make a a list [1,..,20]
// write function to square that list

using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static List<double> squareList(List<double> array){
    // could be int to save memory, but I wanted double to expand as desired
    List<double> squares=new List<double>();
    foreach(double n in array){
      squares.Add(n*n);
    }
    
    return squares;
  }
  public static void Main()
  {
    List<double> list=new List<double>();
    for (int i=1; i<=20; i++){
      list.Add(i);
    }
    
    int j=0; // count iteration to remove last comma in written output
    foreach(double item in squareList(list)){
      
      if(j==list.Count-1){ // make output pretty: removes comma from final item
        Console.Write("{0}\n\n", item);
        break;
      }
      Console.Write("{0}, ", item);
      j++;
      
    }
  }
}
