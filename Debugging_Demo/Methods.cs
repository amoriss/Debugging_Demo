using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_Demo;
internal class Methods
{
    private static Random r = new Random(); 
    
    public static void DoesSomething()
    {
        //int randomNumber = r.Next(1, 10);
        Console.Write("Type something here: ");
        var parsedNumber = int.Parse(Console.ReadLine());   
        Console.WriteLine($"random {r.Next(1, 10)}");
        Console.WriteLine();
    }
}
