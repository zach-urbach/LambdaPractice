using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", "Soccer Ball",
                "Football", "Shoulder Pads", "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};

            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
       //or list<string>                                           //or .ToList();
            var kayakProducts = products.Where(x => x.Contains("Kayak"));
            //print the kayakProducts to the console using a foreach loop.
                //or string
            foreach (var item in kayakProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //the same as the one abouve but shorter
                                     //or "\n"
            Console.WriteLine(string.Join(" ", kayakProducts));
            Console.WriteLine();
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
       //or list<string>                                          //or .ToList();
            var shoeProducts = products.Where(x => x.Contains("Shoes"));
            //print the shoeProducts to the console using a foreach loop.
                //or string
            foreach (var item in shoeProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
       //or list<string>                                                               //or .ToList();
            var ballProducts = products.Where(x => x.Contains("Ball") || x.Contains("ball"));
            //print the ballProducts to the console using a foreach loop.
                //or string
            foreach (var item in ballProducts)
            {
                Console.WriteLine(item);
            }
            //or Console.WriteLine(string.Join(" ", ballProducts));
            Console.WriteLine();
            //sort ballProducts alphabetically and print them to the console.
            ballProducts = products.OrderBy(x => x);
            foreach (var item in ballProducts)
            {
                Console.WriteLine(item);
            }
            //or Console.WriteLine(string.Join(" ", ballProducts.OrderBy(x => x)));
            Console.WriteLine();
            //add six more items to the products list using .add().
            products.Add("apples");
            products.Add("mangos");
            products.Add("chesse");
            products.Add("gold fish");
            products.Add("monkeys");
            products.Add("chessecake");
            //add multiple items at once
            //products.AddRange()nem list<string>() {"apples", "bongos", "zapper"});

            //print the product with the longest name to the console using the .First() extension.
            var longestName = products.OrderByDescending(x => x.Length).First();
            //or Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            Console.WriteLine(longestName);
            Console.WriteLine();
            //print the product with the shortest name to the console using the .First() extension.
            var shortestName = products.OrderBy(x => x.Length).First();
            //or Console.WriteLine(products.OrderBy(x => x.Length).First());
            Console.WriteLine(shortestName);
            Console.WriteLine();
            //print the product with the 4th shortest name to the console using an index (you must convert the results to a list using .ToList()).
            var fourthshortestName = products.OrderBy(x => x.Length).ToList()[3];
            Console.WriteLine(fourthshortestName);
            //or Console.WriteLine(products.OrderBy(x => x.Length).Skip(3).Take(1).First());
            Console.WriteLine();
            //print the ballProduct with the 2nd longest name to the console using an index(you must convert the results to a list using .ToList()).
            var secondlongestName = products.OrderBy(x => x.Length).ToList()[1];
            Console.WriteLine(secondlongestName);
            Console.WriteLine();
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDecending() extension).
            var resersedProducts = products.OrderByDescending(x => x.Length).ToList();
            //print out the reversedProducts to the console using a foreach loop.
            foreach (var item in resersedProducts)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //You will not use a variable to store your list
            var longestWord = products.OrderByDescending(x => x.Length).ToList();
            foreach (var item in longestWord)
            {
                Console.WriteLine(item);
            }
            //or Console.WriteLine(String.Join(", ", products.OrderByDescending(x => x.Length).ThenBy(x => x)));
            Console.ReadKey();
        }
    }
}
