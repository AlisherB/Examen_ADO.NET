using System;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 db = new Model1();
            var allOrders = db.Orders.ToList();
            var allEmployees = db.Employees.ToList();
            var allOrderDetails = db.Order_Details.ToList();
            var allProducts = db.Products.ToList();
            ////1.
            //var task1 = from p in allOrders
            //            orderby p.OrderDate
            //            select p;
            //WriteLine($"Самый старый заказ: { task1.First().OrderID } - { task1.First().OrderDate }");
            //WriteLine($"Самый новый заказ: { task1.Last().OrderID } - { task1.Last().OrderDate }");

            ////3.

            //int postalCode;
            //var task3 = from p in allEmployees
            //            let num = int.TryParse(p.PostalCode, out postalCode)
            //            where num == true
            //            select new { p.EmployeeID, p.PostalCode };
            //WriteLine("ID-s отрудников, у которых Postal состоит исключительно из чисел: ");
            //foreach (var item in task3)
            //{
            //    WriteLine(item + " - " + item.PostalCode);
            //}

            //5.

            //var task5 = from p in allOrders
            //            orderby p.EmployeeID
            //            group p by p.EmployeeID into g
            //            select new
            //            {
            //                EmployeeId = g.Key,
            //                Order = from o in g select o.OrderID
            //            };

            //foreach (var item in task5)
            //{
            //    WriteLine($"EmployeeID: { item.EmployeeId }");
            //    foreach (var innerItem in item.Order)
            //    {
            //        WriteLine($"OrderID: {innerItem}");
            //    }
            //}

            ////7.
            
            //int orderId = allOrderDetails[0].OrderID;
            //WriteLine(orderId);
            //foreach (var item in allOrderDetails)
            //{
            //    if (item.OrderID != orderId)
            //    {
            //        orderId = item.OrderID;
            //        WriteLine(orderId);
            //    }
            //    foreach (var innerItem in allProducts)
            //    {
            //        if (item.ProductID == innerItem.ProductID)
            //        {
            //            WriteLine(innerItem.ProductName);
            //        }
            //    }
            //}

            ////8.

            //var task8 = allOrders.OrderBy(p => p.CustomerID);
            //string customerId = allOrders[0].CustomerID;
            //WriteLine(customerId);

            //foreach (var item in task8)
            //{
            //    if (item.CustomerID != customerId)
            //    {
            //        customerId = item.CustomerID;
            //        WriteLine(customerId);
            //    }
            //    WriteLine(item.EmployeeID);
            //}

            ////9.
            
            //foreach (var product in allProducts)
            //{
            //    WriteLine(product.ProductName);
            //    foreach (var innerItem in allOrderDetails)
            //    {
            //        if (product.ProductID == innerItem.ProductID)
            //        {
            //            foreach (var customer in task8)
            //            {
            //                if (customer.OrderID == innerItem.OrderID)
            //                {
            //                    WriteLine(customer.CustomerID);
            //                }
            //            }
            //        }
            //    }
            //}

            ReadLine();
        }
    }
}
