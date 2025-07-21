using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Inhertitance
            //- Why and when
            // - we can put code in a class, then there's another class
            // that kinds of like it, a child of it want to use functionaltiy of it in a child class. 
            //Car car = new Car();


            List<Phone> phones = new List<Phone>();
            phones.Add(new CellPhone());
            phones.Add(new SmartPhone());

            foreach (var phone in phones)
            {
                if (phone is CellPhone cell) // is ccheck
                {
                    cell.Carrier = "";
                } 

                if (phone is SmartPhone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }
            // even thouh ou  are storing it with teh smaller typ,e type has less stuff int it, does not mean you ar leimited tothat type.
            // add all different types and store it inthe same list
            

            //Phone phone = new SmartPhone();
            // a child class should always be able to fill in for the parent cclass.
            SmartPhone smartPhone = new SmartPhone();
            LandLine landLine = new LandLine();
            
            // cannot inherit more than one parent.
            //Corolla corolla = new Corolla();
            
            // abiltiy o bring code from parent class to a child class
            Console.ReadLine();

            // a class should be its own file
        }

        public class WalkieTalkie
        {

        }
    }
}
