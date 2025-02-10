using System.Collections;
using System.Threading;
using static ass01Linq.ListGenerator;
namespace ass01Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0
            //         select P;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);
            //Result = from P in ProductsList
            //         where P.UnitsInStock > 0 && P.UnitPrice > 3.00M
            //         select P;
            //foreach (var item in Result)
            //{
            //    System.Console.WriteLine(item);
            //}
            #endregion

            #region 3. Returns digits whose name
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(A => A > 5).ElementAt(1);

            //Console.WriteLine(Result);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count (A => A % 2 != 0) ;
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var Result = CustomersList.Select(c => new { CustomerName = c.CustomerName, OrderCount = c.Orders.Count() }).ToList();
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has

            //var Result = ProductsList 
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, ProductCount = g.Count() })
            //    .ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int Result = Arr.Sum();
            //Console.WriteLine(Result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //int totalCharacters = dictionary.Select(word => word.Length) .Aggregate(0, (total, currentLength) => total + currentLength); 
            //Console.WriteLine(totalCharacters);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //int shortestLength = dictionary.Select(word => word.Length).Aggregate((minLength, currentLength) => currentLength < minLength ? currentLength : minLength);

            //Console.WriteLine(shortestLength);

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //int longestLength = dictionary.Select(word => word.Length) .Aggregate(0, (maxLength, currentLength) => currentLength > maxLength ? currentLength : maxLength);
            //Console.WriteLine(longestLength);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");

            //var averageLength = dictionary.Select(word => word.Length).Average(); 
            //Console.WriteLine(averageLength);
            #endregion


            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var Result = ProductsList.OrderBy(p => p.ProductID);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(Result);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr = Arr.OrderBy(A => A.Length).ToArray();
            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var sortedProducts = ProductsList.OrderByDescending(p => p.UnitsInStock).ToList();
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product.UnitsInStock);
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var sortedDigits = Arr.OrderBy(A => A.Length).ThenBy(A => A).ToArray();
            //foreach (var item in sortedDigits)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr.OrderBy(A => A.Length).ThenBy(A => A).ToArray();
            //foreach (var Item in sortedWords)
            //{
            //    Console.WriteLine(Item);
            //}

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var sortedProducts = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();

            //foreach (var item in sortedProducts)
            //{
            //    Console.WriteLine(item.UnitPrice);
            //}
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWordsDescending = Arr.OrderBy(A => A.Length).ThenByDescending(A => A).ToArray();
            //foreach (var word in sortedWordsDescending)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"Zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var filteredReversedDigits = Arr.Where(name => name.Length > 1 && name[1] == 'i') .Reverse().ToArray();
            //foreach (var name in filteredReversedDigits)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var productNames = ProductsList.Select(p => p.ProductName).ToList();

            //Console.WriteLine("Product Names:");
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var transformedWords = words.Select(w => new {UpperCase = w.ToUpper(), LowerCase = w.ToLower()}).ToList();

            //foreach (var word in transformedWords)
            //{
            //    Console.WriteLine($" {word.UpperCase}, {word.LowerCase}");
            //}

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var productInfo = ProductsList.Select(p => new{  p.ProductName,p.UnitPrice }).ToList();
            //foreach (var item in productInfo)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.


            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select (a, b);
            //Console.WriteLine("Pairs where a < b");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"({pair.a} is less than {pair.b})");
            //}

            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var Result = CustomersList.Where(C=>C.Orders.Count()<500).SelectMany(C => C.Orders);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.
            //var recentOrders = Order.Where(C => C.Orders.Count() < 500).SelectMany(C => C.Orders);
            //foreach (var order in recentOrders)
            //{
            //    Console.WriteLine(order.OrderId);
            //}

            #endregion
            #endregion


        }
    }
}