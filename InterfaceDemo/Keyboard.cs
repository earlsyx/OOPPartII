using System;

namespace InterfaceDemo
{
    public class Keyboard : IComputerController //hence captial I so we know wright a way it's an interface.
        // can inherit from a class, and implement one or more interfaces.
    {
        public void Connect()
        {

        }

        //Events- we fire of an event when a keyboard is pressed
        // caller keeps asking.

        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string ConnectionType { get; set; }


    }
}
