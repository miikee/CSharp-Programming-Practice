// Write a function that checks whether an element occurs in a list. *changed to array for own practice
// Note: this would be better accomplished with List, but I wanted to practice arrays
using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static bool isInArray<T>(T[] array, T match){
    string[] strArray = new string[array.Length];
    string strMatch;
    
    try{
      for(int i=0; i<array.Length; i++){
      	strArray[i]=Convert.ToString(array[i]);
      }
      strMatch=Convert.ToString(match);
    }
    catch(Exception e){
      Console.Write("Could not convert array items to string.");
      return false;
    }
    foreach(string item in strArray){
      if (strMatch==item){return true;}
    }
    return false;
  }
    
  public static void Main()
  {
    string[] array={"abc", "def", "ghi", "jkl", "mno"};
  	Console.WriteLine(isInArray<string>(array, "abc"));
    
    int[] array2={1,2,3,4,5,6};
    Console.WriteLine(isInArray<int>(array2, 6));
    
    bool[] array3={true, true, true};
    Console.WriteLine(isInArray<bool>(array3, false));
  }
}