﻿using System;

namespace MiniProjectInheritance
{
    public class ExcavatorModel : InventoryItemModel, IRentalable
    {
        public void Dig()
        {
            Console.WriteLine("I am digging");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;  
            Console.WriteLine("The excavator has been returned");
        }
    }


}
