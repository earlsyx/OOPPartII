using DemoLibrary;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            //DataAccess data = new DataAccess();
            //data.GetConnectionString();
            person.SavePerson();
            Console.ReadLine();
        }
    }

    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            //DataAccess data = new DataAccess();
            //can't access even though you are inheriting from it
            ModifiedDataAccess data = new ModifiedDataAccess();
            data.GetUnsecureConnectionInfo();
            formerLastName = "Test"; 

            //security is not more so to secure your data
            //more about saying these are the things we want to have you use, and these are the things we don't want you to use

            //can i get around . tyes? not the point.
            // when i say data. i only want things im allowed to do, filter aonly want you want.

            // layer security, ui should not have access to connection string datacess so mark as internal.
            // sss private, so nobody have access to creatae a screuity flaw, convenient security. not lock down , everytihn is totally secure.
           
        }
    }
}
