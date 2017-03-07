// Write a function that returns the elements on odd positions in a list.
// Changed this to an array, instead of list to make things more difficult
using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static T[] findOddPosElements<T>(T[] array){
		int length=array.Length/2;  //length to initialize the array
    if (array.Length%2!=0){ length++;}  // if odd array length, then add 1
    T[] holder = new T[length]; // initialize returned array
    
    int j=0;  // used to iterate through new array holder
    for(int i=0; i<array.Length; i++){
      if(i%2==0){  // due to the index starting at 0, each odd element has an even index
        holder[j]=array[i];
        j++;
      }
    }
    return holder;
  }
  public static void outputOddPosElements<T>(T[] array){
    // writes out array 
    foreach(T item in findOddPosElements(array)){
			Console.WriteLine(item);
    }
  }
    
  public static void Main()
  {
    string[] array={"abc", "def", "ghi", "jkl", "mno"};
  	outputOddPosElements<string>(array);
    
    int[] array2={1,2,3,4,5,6};
    outputOddPosElements<int>(array2);
    
    bool[] array3={true, true, true};
    outputOddPosElements<bool>(array3);
  }
}
