using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */
        static void Main()
        {
            //PrintOutOfStock();
            //InStockMoreThan3();
            //CustomersInWa();
            //ListProducts();
            //PricesUp();
            //Capitalizing();
            //EvenLeft();
            //ReverseC();
            //ProductsAZ();
            //InStockDown();
            //First3Wa();
            //First3A();
            //Skip3A();
            //OddsInA();
            //SmallOrder();
            //ByCategory();
            //til6();
            //AllButFirst2WA();
            //ProductWithPrice();
            //UntilLower();
            //SkipUntil3();
            //IDsandCount();
            //CategoryCount();
            //FirstOf12();
            //SortByCategoryAndUnit();
            //GroupByRemainder();
            //TotalUnits();
            //LowestPrice();
            //HighestPrice();
            //AveragePrice();
            //YearMonth();
            //OnlyInStock();
            //LessBThanC();
            //UniqueProductCategories();
            //UniqueAandB();
            //SharedAandB();
            //OnlyInA();
            //Is789Real();
            //AtLeastOneGone();
            IsBLessThan9();
            Console.ReadLine();
        }


        ////1. Find all products that are out of stock.
        //private static void PrintOutOfStock()
        //{
        //    var products = DataLoader.LoadProducts();

        //    //var results = products.Where(p => p.UnitsInStock == 0);
        //    var results = from p in products
        //        where p.UnitsInStock == 0
        //        select p;

        //    foreach (var product in results)
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}

        //2. Find all products that are in stock and cost more than 3.00 per unit.
        private static void InStockMoreThan3()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          where p.UnitsInStock >= 1
                          where p.UnitPrice >= 3.00M
                          select p;

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }

        }

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
        private static void CustomersInWa()
        {
            var customers = DataLoader.LoadCustomers();

            //var CustomerOrders = customers.Orders;
            var results = from t in customers
                          where t.Region == "WA"
                          select t;

            foreach (var customer in results)
            {
                Console.WriteLine(customer.CompanyName);

                foreach (var w in customer.Orders)
                {
                    Console.WriteLine($"{w.OrderDate}, {w.OrderID}, {w.Total}");
                }

            }
        }
        //4. Create a new sequence with just the names of the products.
        private static void ListProducts()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          select p;

            foreach (var p in results)
            { Console.WriteLine(p); }

        }
        //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
        private static void PricesUp()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          select new { p.ProductName, NewPrice = (p.UnitPrice * .25M) };



            foreach (var p in results)
            {
                Console.WriteLine($"{p.ProductName}, {p.NewPrice:C}");

            }

        }
        //6. Create a new sequence of just product names in all upper case.
        private static void Capitalizing()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          select new { upperCase = p.ProductName.ToUpper() };


            foreach (var p in results)
            { Console.WriteLine(p.upperCase); }
        }

        //7. Create a new sequence with products with even numbers of units in stock.
        private static void EvenLeft()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          where p.UnitsInStock > 0
                          where p.UnitsInStock % 2 == 0
                          select p;

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
        private static void ProductWithPrice()
        {
            var products = DataLoader.LoadProducts();
            var result = from p in products
                         select new { p.ProductName, p.Category, Price = p.UnitPrice };

            foreach (var p in result)
            {
                Console.WriteLine($"Name: {p.ProductName}, Category: {p.Category}, Price: {p.Price:C}");
            }

        }

        //9. Make a query that returns all pairs of numbers from both arrays 
        //such that the number from numbersB is less than the number from numbersC.
        private static void LessBThanC()
        {
            int[] numbersb = DataLoader.NumbersB;
            int[] numbersc = DataLoader.NumbersC;
            int i = -1;
            var results = from b in numbersb
                          let index = i++
                          where b < numbersc[i]
                          select new { b, c = numbersc[i] };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.b} - {result.c}");
            }

        }


        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
        private static void SmallOrder()
        {
            var customers = DataLoader.LoadCustomers();
            var products = DataLoader.LoadProducts();
            var results = from c in customers
                          select c;

            foreach (var c in results)
            {

                foreach (var w in c.Orders)
                {
                    if (w.Total <= 500)
                    {
                        Console.WriteLine($"{c.CustomerID}, {w.OrderID}, {w.Total}");
                    }
                }
            }




        }
        //11. Write a query to take only the first 3 elements from NumbersA.
        private static void First3A()
        {
            var numbers = DataLoader.NumbersA;
            var results = numbers.Take(3);

            foreach (var n in results)
            {
                Console.WriteLine(n);
            }
        }

        ////12. Get only the first 3 orders from customers in Washington.
        private static void First3Wa()
        {
            var customers = DataLoader.LoadCustomers();
            var results = (from c in customers
                           from o in c.Orders
                           where c.Region == "WA"
                           select new { c.CompanyName, o.OrderID, o.OrderDate })
                          .Take(3);

            foreach (var order in results)
            {
                Console.WriteLine($"{order.CompanyName}, {order.OrderID}, {order.OrderDate}");
            }


        }



        //13. Skip the first 3 elements of NumbersA.
        private static void Skip3A()
        {
            var numbers = DataLoader.NumbersA;
            var result = numbers.Skip(3);
            foreach (int n in result)
            {
                Console.Write(n);
            }
        }

        //14. Get all except the first two orders from customers in Washington.
        private static void AllButFirst2WA()
        {
            var customers = DataLoader.LoadCustomers();
            var results = (from c in customers
                           from o in c.Orders
                           where c.Region == "WA"
                           select new { c.CustomerID, o.OrderID, o.OrderDate })
                           .Skip(2);

            foreach (var order in results)
            {
                Console.WriteLine(order);
            }


        }
        ////15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        private static void til6()
        {
            var numbers = DataLoader.NumbersC;
            var results = numbers.TakeWhile(n => n < 6);



            foreach (var p in results)
            {
                Console.WriteLine(p);
            }
        }
        //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
        private static void UntilLower()
        {
            var numbers = DataLoader.NumbersC.TakeWhile((num, index) => num >= index);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }


        //17. Return elements from NumbersC starting from the first element divisible by 3.
        private static void SkipUntil3()
        {
            var numbers = DataLoader.NumbersC.SkipWhile(num => num % 3 != 0);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

        }
        //18. Order products alphabetically by name.
        private static void ProductsAZ()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          orderby p.ProductName
                          select p;

            foreach (var p in results)
            {
                Console.WriteLine($"{p.ProductName}");
            }
        }
        //19. Order products by UnitsInStock descending.
        private static void InStockDown()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          orderby p.UnitsInStock descending
                          select p;
            foreach (var p in results)
            {
                Console.WriteLine($"{p.ProductName}, {p.UnitsInStock}");
            }
        }

        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
        private static void SortByCategoryAndUnit()
        {
            var products = DataLoader.LoadProducts();
            var result = from p in products
                         orderby p.Category, p.UnitPrice descending
                         select p;


            foreach (var p in result)
            {
                Console.WriteLine($"{p.Category} {p.ProductName} {p.UnitPrice:C}");

            }
        }

        ////21. Reverse NumbersC.
        private static void ReverseC()
        {
            var numbers = DataLoader.NumbersC;
            var backwards = (from n in numbers
                             select n).Reverse();
            foreach (var n in backwards)
            {
                Console.WriteLine(n);
            }

        }
        //22. Display the elements of NumbersC grouped by their remainder when divided by 5.
        public static void GroupByRemainder()
        {
            var numbers = DataLoader.NumbersC;
            var sorted = from n in numbers
                         group n by n % 5 into g
                         select new { Remainder = g.Key, Numbers = g };
            foreach (var g in sorted)
            {
                Console.WriteLine($"Numbers with a remainder of {g.Remainder}");
                foreach (var n in g.Numbers)
                {
                    Console.WriteLine($"\t {n} ");
                }
            }
        }

        ////23. Display products by Category.
        private static void ByCategory()
        {
            var products = DataLoader.LoadProducts();
            var result = products.GroupBy(c => c.Category);


            foreach (var g in result)
            {
                Console.WriteLine($"{g.Key}:");
                foreach (var p in g)
                {
                    Console.WriteLine($"\t {p.ProductName}");
                }
            }



        }

        //24. Group customer orders by year, then by month.
        private static void YearMonth()
        {
            var customers = DataLoader.LoadCustomers();
            var results = from c in customers
                          select new
                          {
                              c.CompanyName,
                              YearGroups =
                              from o in c.Orders
                              group o by o.OrderDate.Year into yg
                              select new
                              {
                                  Year = yg.Key,
                                  MonthGroups =
                                  from o in yg
                                  group o by o.OrderDate.Month into mg
                                  select new { Month = mg.Key, Orders = mg }
                              }
                          };
            foreach (var result in results)
            {
                Console.WriteLine(result.CompanyName);

                foreach (var yg in result.YearGroups)
                {
                    Console.WriteLine("\t{0}", yg.Year);
                    foreach (var mg in yg.MonthGroups)
                    {
                        Console.WriteLine($"\t\t{mg.Month}");


                        foreach (var order in mg.Orders)
                        {
                            Console.WriteLine($"\t\t\t{order.OrderDate}, {order.OrderID}");
                        }
                    }
                }
            }
        }

        //25.  Create a list of unique product category names.

        private static void UniqueProductCategories()
        {
            var products = DataLoader.LoadProducts();
            var results = (from p in products
                           select p.Category).Distinct();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //26. Get a list of unique values from NumbersA and NumbersB.
        private static void UniqueAandB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Union(numbersB);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //27. Get a list of the shared values from NumbersA and NumbersB.
        private static void SharedAandB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Intersect(numbersB);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //28. Get a list of values in NumbersA that are not also in NumbersB.
        private static void OnlyInA()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Except(numbersB);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //29. Select only the first product with ProductID = 12 (not a list).
        private static void FirstOf12()
        {

            var products = DataLoader.LoadProducts();
            var first = from p in products
                        where (p.ProductID == 12)
                        select p;

            foreach (var f in first)
            {
                Console.WriteLine(f.ProductName);
            }
        }

        //30. Write code to check if ProductID 789 exists.
        private static void Is789Real()
        {
            var products = DataLoader.LoadProducts();
            var results = products.FirstOrDefault(p => p.ProductID == 789);

            Console.WriteLine("Product 789 exists: {0}", results != null);
          }
        

        //31. Get a list of categories that have at least one product out of stock.
        private static void AtLeastOneGone()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category
                          into pCats
                          where pCats.Any(x => x.UnitsInStock == 0)
                          select new { pCats.Key, coll = pCats };



            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key}");
            }

                        
        }

        //32. Determine if NumbersB contains only numbers less than 9.
        private static void IsBLessThan9()
        {
            var numbersB = DataLoader.NumbersB;

            var results = numbersB.Max();

            if (results >= 9)
            {
                Console.WriteLine("NumbersB does not contain only numbers less than 9.");
            }

            else
            {
                Console.WriteLine("NumbersB only contains numbers less than 9.");
            }
        }

        

        //33.Get a grouped a list of products only for categories that have all of their products in stock.
        private static void OnlyInStock()
        {
            var products = DataLoader.LoadProducts();
            var group = from p in products
                        group p by p.Category into g
                        where g.All(x => x.UnitsInStock > 0)
                        select new { g.Key, coll = g };

            foreach (var g in group)
            {

                Console.WriteLine($"{g.Key}");
                foreach (var product in g.coll)
                {
                    Console.WriteLine($"\t{product.UnitsInStock} - {product.ProductName}");
                }
            }



        }
        //34. Count the number of odds in NumbersA.
        private static void OddsInA()
        {
            //int oddcounter = 0;
            var numbers = DataLoader.NumbersA;
            var odds = from n in numbers
                       where (n % 2 != 0)
                       select n;
            //foreach (var n in odds)
            //{
            //    oddcounter++;

            //}
            Console.WriteLine(odds.Count());
        }

        //35. Display a list of CustomerIDs and only the count of their orders.
        //public static void IDsandCount()
        //{
        //    var customers = DataLoader.LoadCustomers();

        //    foreach (var c in customers)
        //    {
        //        Console.WriteLine($"{ c.CustomerID}, {c.Orders.Count()}");
        //    }

        //}

        //36. Display a list of categories and the count of their products.
        //public static void CategoryCount()
        //{
        //    var products = DataLoader.LoadProducts();
        //    var group = from p in products
        //                group p by p.Category into newGroup
        //                orderby newGroup.Key
        //                select newGroup;




        //    foreach (var g in group)
        //    {
        //        Console.WriteLine($"{g.Key}: {g.Count()}");

        //    }
        //}
        //37. Display the total units in stock for each category.
        public static void TotalUnits()
        {
            var products = DataLoader.LoadProducts();
            var group = from p in products
                        group p by p.Category into newGroup
                        orderby newGroup.Key
                        select newGroup;

            foreach (var g in group)
            {
                Console.WriteLine($"{g.Key}: {g.Sum(p => p.UnitsInStock)}");


            }
        }
        //38. Display the lowest priced product in each category.
        public static void LowestPrice()

        {
            var products = DataLoader.LoadProducts();
            var categories = from p in products
                             orderby p.UnitPrice descending
                             group p by p.Category into g
                             select g;

            foreach (var c in categories)
            {
                Console.WriteLine($"{c.Key}: {c.Last().ProductName}");
            }

        }
        //39. Display the highest priced product in each category.
        public static void HighestPrice()

        {
            var products = DataLoader.LoadProducts();
            var categories = from p in products
                             orderby p.UnitPrice descending
                             group p by p.Category into g
                             select g;

            foreach (var c in categories)
            {
                Console.WriteLine($"{c.Key}: {c.First().ProductName}");
            }

        }


        //40. Show the average price of product for each category.
        public static void AveragePrice()
        {
            var products = DataLoader.LoadProducts();
            var categories = from p in products
                             group p by p.Category into g
                             orderby g.Key
                             select g;

            foreach (var c in categories)
            {
                Console.WriteLine($"{c.Key}: {c.Average(p => p.UnitPrice):C}");
            }

        }
    }
}


