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
        string inputString = Console.ReadLine(); //input String
        string[] inputInArray = inputString.Split(' '); //split in Array

        var groups = inputInArray.GroupBy(name => name); //sort the Array
        foreach (var group in groups)
        {
            Console.WriteLine(string.Join(" ", group));
        }
        Console.WriteLine();
     }
}

