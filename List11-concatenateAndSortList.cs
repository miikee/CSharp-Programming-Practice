// Write a function that merges two sorted lists into a new sorted list. 
// [1,4,6],[2,3,5] -> [1,2,3,4,5,6]. 
// You can do this quicker than concatenating them followed by a sort.
/*
Was trying to do too much with this code.  Was trying to combine any data type in arrays... sort of succeeded.
Spent more time dealing with datatypes and generics than actually coding the logic behind a sorting function.

After working with datatypes forever, I decided to write a function for just the double datatype and use the 
.Sort() function for the string datatypes, since the excercise was originally only for integers anyways.
Datatypes were not what the excercise was about anyways.  More about the logic behind sorting.
*/

using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  /* This is where I stopped trying to include every datatype there is.
  It was taking too long and probably not what the excercise was about. 
  
  public static List<T> sortString<T>(List<T> list){
   	List<T> sortedList;
    T holder;
    int movedItems=0;
    
    for(int i=0; i<list.Count; i++){
      if(list[i].Compare(list[i+1])){  //swap
        holder=list[i];
        list[i]=list[i+1];
        list[i+1]=holder;
      }
    }
    return sortedList;
  }*/
  
  public static List<double> sortList(List<double> list){
    // sort a list using recursive method loops
    //List<double> sortedList = new List<double>();
    double holder;
    
    for(int i=0; i<list.Count-1; i++){
      if(list[i]>list[i+1]){  //swap
        holder=list[i];
        list[i]=list[i+1];
        list[i+1]=holder;
        sortList(list);
      }
    }
    return list;
  }
  
  
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
  
  
  public static List<object> sortList(List<object> list){
    // change object datatype items in list to double datatypes
    string strItem;
    double dblItem;
    List<double> dblList=new List<double>(); // holds list of objects that can be made into doubles
    List<string> strList=new List<string>(); // holds list of objects that cnanot be made into doubles
    
    foreach(object item in list){
      strItem=item.ToString(); // convert item to string representation of object
      
        
      if(double.TryParse(strItem, out dblItem)){
        // if element can be made double, add it to double list
        dblList.Add(dblItem);
      }
      else{
        // if element cannot be made double, add it to string list
        strList.Add(strItem);
      }
      
    }
    //sort both lists and then concatenate them with doubles first.
    //dblList.Sort(); Rewrote using a method I created
    dblList=sortList(dblList);
    strList.Sort(); 
      
      
    // convert lists back in List<object> to be concatenated... code turned into a DISASTER!
    List<object> dblListObj= dblList.Cast<object>().ToList();
    List<object> strListObj= strList.Cast<object>().ToList();
      
    return concatenateLists(dblListObj, strListObj);
    
  }
  public static void Main()
  {
    List<object> list1=new List<object>{3,5,6,2, "abc", "cat", "dog"};
    List<object> list2=new List<object>{2.0, 4.33, 8, 12, 15.33};
    
    
    List<object> combinedList=concatenateLists(list1, list2);
    combinedList=sortList(combinedList);
    
    int j=1;
    foreach(object item in combinedList){
   		//vstring strItem=Convert.ToString(item);  //convert object back to string to be written to screen 
      if(j==combinedList.Count) Console.Write("{0} \n\n", item);
      else Console.Write("{0}, ",item);
     j++;
    }
  }
}

