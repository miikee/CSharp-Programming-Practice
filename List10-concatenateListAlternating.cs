//Write a function that combines two lists by alternatingly taking elements, 
// e.g. [a,b,c], [1,2,3] -> [a,1,b,2,c,3].
// I'll b assuming same size lists for this program
using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static List<object> concatenateLists(List<object> list1, List<object> list2){
    List<object> combinedList=new List<object>();
    int totalLength=list1.Count+list2.Count;
    for(int i=0; i<totalLength; i++){
      if(i%2==0)combinedList.Add(list1[i/2]);
      else combinedList.Add(list2[i/2]);
    }
       
    
    return combinedList;
  }
  public static void Main()
  {
    List<object> list1=new List<object>{1, 2, 3, "cat", "dog"};
    List<object> list2=new List<object>{"a","b","c", 2.0, 4.33, 5};
    
    if(list1.Count!=list2.Count){// check that the arrays are the same size
      Console.WriteLine("Error: The input arrays must be the same size.");
      return;
    }
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
