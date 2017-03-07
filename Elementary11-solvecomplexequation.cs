// Solve this equation:
// 4\cdot \sum_{k=1}^{10^6} \frac{(-1)^{k+1}}{2k-1} = 4\cdot(1-1/3+1/5-1/7+1/9-1/11\ldots)
// code is in LaTex
// 4*sigma_sum(from k=1 to 10^6) [-1^(k+1)]/[2k-1]= 4*[1-1/3+1/5-1/7+1/9-1/11...]
using System.IO;
using System;
using System.Collections.Generic;

class Program
{   
    static void Main(){
        double k=1;
        double kend=Math.Pow(10,6);
        double sum=0;
        double result=0;
        
        for (k=1; k<=kend; k++){
            double top=Math.Pow(-1,k+1);
            double bottom=(2*k)-1;
            double iteration=top/bottom;
            //Console.WriteLine("{0}/{1}", top, bottom);
            sum+=iteration;
        }
        result=4*sum;
        Console.WriteLine(result); // turns out to be pi
    
    }
}
