namespace InterfaceDemo
{
    //What SOLID talks about 
    // idea how to acrhitecture an application in such away that it's a bunch of modular pieces that can get pulled a part and replace one at a time. Instead of redoing entire application to fix one piece.
    // interfacs clitral . important

    public class BatteryPoweredGameController : GameController, IBatteryPowered //inherits first the implementation
    {
        public int BatteryLevel { get; set; }

    }
}
