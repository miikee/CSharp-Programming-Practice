// write a function that returns the largest element in a list

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
	    static int findLargest(int[] array){
	        int largest=array[0];
	        foreach (int item in array){
	            if (item>largest) largest=item;
	        }
	        return largest;
	        
	    }
		static void Main(string[] args)
		{
		    int[] array = {100,89,12,53,2312,324,32,232};
		    
		    Console.WriteLine(findLargest(array));
		}
	}
}
