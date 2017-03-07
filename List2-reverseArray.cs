// Write function that reverses a list, preferably in place.
using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static int[] reverseList(int[] list){
  	//reverses a list
    int[] reversedList=new int[list.Length];
    for(int i=0; i<list.Length; i++){
    	reversedList[i]=list[list.Length-1-i];  
    }
    
    return reversedList;
    
  }
  public static void Main()
  {
    int[] list={12,42,423,23,12,43,234,12};
    foreach(int item in reverseList(list)){
      Console.Write("{0}, ", item);
    }
  }
}
