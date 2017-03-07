//  Write a function that concatenates two lists. 
//  [a,b,c], [1,2,3] -> [a,b,c,1,2,3]

using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static List<object> concatenateLists(List<object> list1, List<object> list2){
    List<object> combinedList=new List<object>();
    foreach(object item in list1){
      combinedList.Add(item);
    }
    foreach (object item in list2){
      combinedList.Add(item);
    }
       
    
    return combinedList;
  }
  public static void Main()
  {
    List<object> list1=new List<object>{1, 2, 3, "cat", "dog"};
    List<object> list2=new List<object>{"a","b","c", 2.0, 4.33};
    List<object> combinedList=concatenateLists(list1, list2);
    
    int j=1;
    foreach(object item in combinedList){
   		//vstring strItem=Convert.ToString(item);  //convert object back to string to be written to screen 
      if(j==combinedList.Count) Console.Write("{0} \n\n", item);
      else Console.Write("{0}, ",item);
     j++;
    }
  }
}
