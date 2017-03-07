// Write three functions that compute the sum of the numbers in a list: 
// using a for-loop, a while-loop and recursion. 
// (Subject to availability of these constructs in your language of choice.)
using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static double forLoopSum(double[] array){
    double sum=0;
    for (int i=0; i<array.Length; i++){
      sum+=array[i];
    }
    return sum;
  }
  public static double whileLoopSum(double[] array){
    double sum=0;
    int i=0;
    while(i<array.Length){
      sum+=array[i];
      i++;
    }
    return sum;
  }
  public static double recursionSum(double[] array, int i=0, double sum=0){
    if(i<array.Length){ 
      sum+=array[i];
      i++;
      return recursionSum(array, i, sum);
    }
    else{return sum;}
    
  }
  public static void Main()
  {
    
    Console.WriteLine("Program sums an array using 3 different methods.");
    double[] array={1.2, 1, 98, 1.34, 7.32};
    Console.WriteLine("\"For Loop\" Sum: {0}", forLoopSum(array));
    Console.WriteLine("\"While Loop\" Sum: {0}",whileLoopSum(array));
    Console.WriteLine("\"Recursion Loop\" Sum: {0}",recursionSum(array));
    Console.WriteLine("Exitted");
  }
}
