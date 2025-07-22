using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book();
            //book.ProductName = "A tale of Two Cities";
            InventoryItem item = new Book(); // abstract concept, not a concrete thing, not specific, not a book, but why am i allow to instantitate it.

            // can isntanitation inventory item type new book bujt can't directly instatite inventory item
            // sxtore inventroy item base a book is an inventori yetem
            Console.ReadLine();
        }
    }

    //abstract classes - a class, a base class
    //class, foundational, you build upon it.
    // not really complete on its own.
    // inventoritem not fully form idea absract 
    // book understands it, autohr etc. inventoritem not a thing, book solid ,inventory item absract.
    // classes that's foundational, you inherit from 
    // but you can't acutally instantitate.
    public abstract class InventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityOnHand{ get; set; }
    }

    public abstract class Vehicle // we can't instantiate but we can inherit from it
    {
        public string Vin { get; set; }//identifies a unique
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    //craete classes that you inherit from it without opening yourself up using the vehicle as a class onto itself. asbract can;t sutantate you have to inherit ti to use the proeprties and methods inside the absracr class.
    //interface different berween avsract classes
    // diference is hat for interface, you have to implement the properties or methods in the contract for class that implements it, but for abstract class, you don't have too, if that abstract class is being implemented / used by a child class. s
    // Methods
    // Abstract same as inherit class, cannot just instinatiate
     public class Car : Vehicle//concrete
    {
        public int NumberOfWheels { get; set; } = 4;

    }
}
