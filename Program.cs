using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// Create a method that takes a list of orders as an argument and return the average sum of its property Amount.
//BONUS: Allow the method to be able to handle two different objects.
// For example a list of Orders and Invoices with same property "Amount".
namespace myCSCode
{
    //create interface to inherit property to child classes
    public interface IForm{
        double amount {get; set;}
    }
    public class Order: IForm{
        public double amount{get; set;}
    }
    public class Invoice: IForm{
        public double amount { get; set;}
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            // create Generic List to test my method
            List<IForm> orderList = new List<IForm>{
                new Invoice {amount = 5.25},
                new Order{amount = -2}
            };
        // call method and pass in order list of different objects
            ReturnAverage(orderList);

            //Console.ReadKey();
        }

        private static double ReturnAverage(List<IForm> orderList)
        {
            double averageSum;
            double amountTotal = 0;
            // loop through list and get total amount;
            for (int i=0; i < orderList.Count; i++){
                amountTotal = amountTotal + orderList[i].amount;
            }
            //calculate average
            averageSum = amountTotal/orderList.Count;
            Console.WriteLine("Average Sum is: " + averageSum);
            return averageSum;
            
        }
    }
}
