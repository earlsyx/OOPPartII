using System.Collections.Generic;

namespace InheritanceDemo
{
    internal partial class Program
    {
        // possible , because it's a is a relation ship, cell phoen is a phone, cellphne as a parent of smartphone is a phone.
        public class SmartPhone : CellPhone //grand parent relationship
        {
            public List<string> Apps { get; set; }
            public void ConnectToInternet()
            {

            }

        }
    }
}
