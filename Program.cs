using AccessModifiersEncapsulationTask.Models;

namespace AccessModifiersEncapsulationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Iphone","15",1500,500,10);
            product.Brand = "21";
            product.Cost = -100;
            product.Price = -90;
            product.PrintInfo();
            Phone phone = new Phone(16, "red", 10m, "Iphone","16 pro", 1500m, 500,3);
            phone.PrintInfo();
            phone.Call(10);
            phone.Pay(100);

        }
    }
}
