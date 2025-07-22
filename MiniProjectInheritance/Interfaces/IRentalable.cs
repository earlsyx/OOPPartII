namespace MiniProjectInheritance
{
    public interface IRentalable : IInventoryItem
    {
        void Rent();
        void ReturnRental();

    }


}
