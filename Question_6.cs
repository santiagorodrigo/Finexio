//6.Given the following C# class definition, use the Enumerable extension methods in LINQ to return the first 3 Names that start with X as a comma-delimited list. (10 points)
//class Product
//{
//	public string Name { get; set; }
//	public double Cost { get; set; }
//}
//static string GetFirst3XNames(IEnumerable<Product> products)
//{
//	// Enter code here
//}


using System;
namespace Finexio
{
	public class Question_6
	{
        class Product
        {
            public string Name { get; set; }
            public double Cost { get; set; }
        }

        static string GetFirst3XNames(IEnumerable<Product> products)
        {
            // Enter code here

            return String.Join(",", products.Where(prod => prod.Name.StartsWith("X")).Take(3));


        }

    }
}

