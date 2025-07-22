using System;

namespace InterfaceDemo
{
    public class GameController : IComputerController, IDisposable
    {


        //repetition, not inhertance, not is a relation ship,
        // /both peripherals? problem is current key preseed is not.
        // not aeverything a pheripiral had currentkeypressed.
        // even if similar, not a same thing.
        public void Connect()
        {
            
        }

        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            //Do whatever shutdown tasks needed.
            // called whenever we shutdown this class or get rid of this class
        }

    }
}
