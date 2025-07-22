using System;

namespace InterfaceDemo
{
    //combining contracts the IComputerController also have IDispoable
    public interface IComputerController : IDisposable // contract/ standars I
    {
        //not actual implementation. 
        // controact, a thing a class will implements
        // definitions only. everyting public, therefore we don't include the word public because it is implied.
        void Connect(); // no public, no curly braces. we only just need the signature line.
        // sginature line - defines the return type, defines the name, defines any parameter you have. 
        void CurrentKeyPressed(); // commonality


    }
}
