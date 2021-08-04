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

      //var numbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

      ////Aggregate method - Contains a single value from the output -> 
      //// Max, Sum, Min, Average, Count 

      //var maxNumber = numbers.Max();
      //Console.WriteLine(maxNumber); // largest value, 300

      //var sumofNumbers = numbers.Sum();
      //Console.WriteLine(sumofNumbers); //added together, 363

      //var averageNumber = numbers.Average();
      //Console.WriteLine(averageNumber); // Takes the average... 

      //var count = numbers.Count();
      //Console.Write(count); // the .Length of the list, or total number of values in list. 


      //// Filter method. Only one we will discuss tonight. Where is like a map method. 
      //var biggerNumbers = numbers.Where(num => num > 9);
      //Console.WriteLine($"biggerNumbers {String.Join(',', biggerNumbers)}");

      ////Projection operation
      ////Select is like Array.map, return a new collection of IEnumberable<T>
      ////Transforming data
      //var biggerNumbers2 = numbers.Select(num => num + 12); // Transform base data by adding 12 to each value. 
      //Console.WriteLine($"biggerNumbers2 {String.Join(',', biggerNumbers2)}");

      //var numbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

      //var firstNumber = numbers.First();
      //var lastNumber = numbers.Last();

      //// Combining a filter on the original list, with only returning the first value. Linking together LINQ methods. 
      //var firstMatchingNumber = numbers.Where(num => num > 9).First();
      //var firstMatchingNumber2 = numbers.First(num => num > 9); // Does the same thing as above, the arrow expression handles the `Where`

      ////Quantifier Operations 
      //// returns a bool if conditions are met. 
      //// all, any, contains 

      //var allNumbers = numbers.All(c => c > 5);
      //Console.WriteLine(allNumbers);

      //var anyNumbers = numbers.Any(c => c > 5);
      //Console.WriteLine(anyNumbers);

      //var hasNumber7 = numbers.Contains(7);
      //Console.WriteLine(hasNumber7);

      // Set Operators
      // Combine the results of two queries into a single result. 
      //// OR Produces a result set that is based on presence or abscense of equivelent elements. 

      //var numbers = new List<int>() { 8, 3, 11, 11, 9, 23, 9, 2, 7, 300 };
      //var badNumbers = new List<int>() { 6, 1, 13, 21, 5, 4, 31, 299, 9, 23 };

      //var onlyGoodNumbers = numbers.Except(badNumbers); // Combines into a single query where it takes all from List A except from List B. 
      //Console.WriteLine($"onlyGoodNumbers {String.Join(',', onlyGoodNumbers)}");

      //var uniqueNumbers = numbers.Distinct(); //removes the duplicate values
      //Console.WriteLine($"uniqueNumbers {String.Join(',', uniqueNumbers)}");

      //// Take the first three numbers, concat or combine that result with again taking numbers, skipping first 5, and taking the first 1 after (6th)
      //var firstThreeNumbersAndTheSixth = numbers.Take(3).Concat(numbers.Skip(5).Take(1));
      //Console.WriteLine($"First3and6th. {String.Join(',', firstThreeNumbersAndTheSixth)}");

      var animals = new List<Animal>()
      {
        new Animal {Type = "Pikachu", WeightInPounds = 3, HeightInInches = 28 },
        new Animal {Type = "Cthulu", WeightInPounds = 2500, HeightInInches = 798},
        new Animal {Type = "Charzard", WeightInPounds = 25, HeightInInches = 40},
        new Animal {Type = "Bulbasaur", WeightInPounds = 45, HeightInInches = 29}
      };

      // Filter the animals with a funciton
      var animalsThatStartWithC = animals.Where(animal => animal.Type.ToLower().StartsWith('c'));
      foreach (var animal in animalsThatStartWithC)
      {
        Console.WriteLine(animal.Type);
      }

      //Group a collection by a given key (based on a function)
      // Group each animal based on a specific filter

      var groupAnimals = animals.GroupBy(animal => animal.Type.First());

      foreach (var animalGroup in groupAnimals)
      {
        Console.WriteLine($"Animals that start with {animalGroup.Key}");

        foreach (var animal in animalGroup)
        {
          Console.WriteLine(animal.Type);
        }
      }

    }
  }
}
