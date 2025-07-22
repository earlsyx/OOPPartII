
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
   //privateprotected - you have access to something, if it's in a class or a derived class in a current assembly

    //only for things inherit from person, but also the same assembly.
    //anything class in the DemoLibrary /project/assembly
    //you can have the class mark as public
    // marks method as protected internal
    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "sensitive";
        }
    }
    public class Person
    {
        //public
        //private 
        // protected allows accessing in the class you created as well, any class that derives from this class, so child class.

        // public private common,
        // protected internal, good value, undrastnd hwo.
        // change later on, protected first etc.

        //public private, then iwant it to be vaible not anywhere or everwher etc.
        //just know their avialabe
        private protected string formerLastName = "";
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private string _ssn;//not returning the actual variable
        // we are returning modified version of it 
        //  public versino returns modifed of private//internal only

        public string SSN
        {
            get 
            { 
                return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; 
            }
            set 
            { 
                _ssn = value; 
            }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            string test = "Hi";
;            Console.WriteLine($"Hello { FirstName }");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string conn = data.GetConnectionString();
            // saves the person
        }
    }

    public class Employee : Person
    {
         public string GetFormerLastName()
        {
            return formerLastName;
        }
    }

    public class Manager : Employee
    {
        public string GetAllNames()
        {
            return $"{FirstName}, {LastName}, {formerLastName}";
        }
    }


}
