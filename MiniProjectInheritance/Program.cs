﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRentalable> rentalables = new List<IRentalable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new Vehicle { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "A tale of Two Cities", NumberOfPages = 350 };
            var excavator= new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentalables.Add(vehicle);
            rentalables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.Write("Do you want to rent or purchased soemthing: (rent, purchase) ");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentalables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item (yes/no): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName} ");
                    Console.Write("Do you want to purchase this product (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }

            Console.WriteLine("We are done");

            Console.ReadLine();
        }
    }


}
