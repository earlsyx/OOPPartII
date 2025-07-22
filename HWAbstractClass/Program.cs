using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleParts vehicle = new Car();
            vehicle.NumberOfWheels = 4;
        }

        
    }
    public interface IVehicleParts
    {
        int NumberOfWheels { get; set; }
    }
    public abstract class Vehicle : IVehicleParts
    {
        public int NumberOfWheels { get; set; }
    }

    public class Car : Vehicle
    {

    }
}
