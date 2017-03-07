using System.IO;
using System;

// Enter your name
// Program greets only alice and bob
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your name:");
        var name=Console.ReadLine();
        string greeting="Hello, thank you for entering your name: ";
        if (name.ToLower()=="Alice".ToLower() || name.ToLower()=="Bob".ToLower()){
            Console.WriteLine(greeting+name);
        }else{
            Console.WriteLine("Hello, unimportant person");
        }
    }
}
