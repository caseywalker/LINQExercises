using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      // A list of numbers that we store to later work on with LINQ
      // var numbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

      //Sorting operators. 
      // OrderBy, OrderByDescenging, and Reverse <-- Fundamentals of LINQ 

      //var orderedNumbers = numbers.OrderBy(num => num);
      //Console.WriteLine("Ordered:");
      //foreach (var num in orderedNumbers)
      //{
      //  Console.WriteLine($"\t{num}");
      //}

      //var descending = numbers.OrderByDescending(num => num);
      //Console.WriteLine("Descending:");
      //foreach (var num in descending)
      //{
      //  Console.WriteLine($"\t{num}");
      //}

      // This mutates the original collection, whereas the others don't. 
      //numbers.Reverse();

      var numbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

      //Aggregate method - Contains a single value from the output -> 
      // Max, Sum, Min, Average, Count 

      var maxNumber = numbers.Max();
      Console.WriteLine(maxNumber); // largest value, 300

      var sumofNumbers = numbers.Sum();
      Console.WriteLine(sumofNumbers); //added together, 363

      var averageNumber = numbers.Average();
      Console.WriteLine(averageNumber); // Takes the average... 

      var count = numbers.Count();
      Console.Write(count); // the .Length of the list, or total number of values in list. 


      // Filter method. Only one we will discuss tonight. Where is like a map method. 
      var biggerNUmbers = numbers.Where(num => num > 9);

    }
  }
}
