using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Hello kattie
 *
 */
class SequencesOfEqualStrings
{
    static void Main()
    {
        string inputString = Console.ReadLine(); 
        string[] inputInArray = inputString.Split(' '); 

        var groups = inputInArray.GroupBy(name => name); 
        foreach (var group in groups)
        {
            Console.WriteLine(string.Join(" ", group));
        }
        Console.WriteLine();
     }
}

