using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    //Interface - is a contract
    // - this is what a class will do that implements this interface.
    // Classes implement interfaces. 
    // Implentation, we can form to whatever contract we say we implement
    // Real life- powercords,chaos, how it plugs in.
    // designers: plan , standadize, interface for house power.
    // standard throughout the country. particular shapes and nubmer of pongs.

    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Keyboard> controllers = new List<Keyboard>();
            List<IComputerController> controllers = new List<IComputerController>();

            // you can put anything you want in there as long as it implements IComputerController interface
            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController battery = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();
            //why do we have the ability to put battery in the list even though we did not put inteface ?
            // because we inherit form game cotnroller and hamcontroller implemnts teh intrafce therefore we can assume that batteypowergamecontroller, bcause gamecontroller does.

            //sinceparent already implements, then child don't have to.
            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(battery);

            foreach (IComputerController controller in controllers)
            {
                if (controller is GameController gc)
                {
                    
                }

                if (controller is IBatteryPowered powered)
                {
                }

                 // since he controolect only has two methods, then only those will be allowed to be shown.
                 // useful- if we have different things that are not quite the same they can't inherit from each other but we want to store them in a list together then use interface.

                // another ,
                // if we want to create a contract that maybe someboday else will implement, we dont realy care. Can be 1 type implements it or 1000 different type implements it 
                // we just need to run a certain sets of commands or gets cetain values out of something regardless what it is.

                //there was one, built it in .net framework called IDisposable
            }

            //beneficial, because microsoft has given as the thing called using statements
            // we can use whatever is IDispoable

            //since it's sa using statemnet it knows that it has a method dispose

            // after end curley , automaticly called gc.Dispose,same with expcetion.

            //load an image, forget, then .net will hold that memory 4ever. bigger, and bigger, more andm ore ram. If you are done, we are going to dispose of that image properly hence you are now save, memory useage goes backdown since we are not  storing that image memory.

            // connection to database.
            // if you open a connection to database inside using statements
            // no matter what, by the end close the connection.
            // early days hundered of open connections to our server when app is closed because connection stays even after app closes, we have to reboot the server in order to clear sessions out. not a good idea.
            // call dispose even in classes we create down the road

            //Interaces, idk who you are but i know you implement this interface there fore i do know i have ccess to whatever inteface says what yo do.

            using (GameController gc = new GameController())
            {

            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(battery);
            powereds.Add(batteryKeyboard);//wont work because a keybaord is not battery powred
            
             
            Console.ReadLine();
        }
    }
}
