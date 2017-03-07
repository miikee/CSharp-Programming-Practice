using System.IO;
using System;

// Greets user with name
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your name:");
        var nm=Console.ReadLine();
        Console.WriteLine("Hello, thank you for entering your name:{0}", nm);
    }
}