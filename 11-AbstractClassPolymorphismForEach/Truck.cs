namespace _11_Abstract_Class
{
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }

        public Truck() : base( brand, model, year,  plateNumber,  fueLevel=100)
        {

        }
        public static void ShowTruckInfo()
        {
            System.Console.WriteLine(CargoCapacity + " " + AxleCount + " " + CurrentLoad + " " + MaxSpeed);

        }
        public static void LoadCargo(double weight)
        {
            if (weight > CargoCapacity)
            {
                System.Console.WriteLine("Uygun deyil");
            }
            else
            {
                System.Console.WriteLine("buyurun");
            }


        }
        public void CalculateFuelCost(double distance)
        {
            (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
        }
        public override void GetVehicleInfo()
        {
            ystem.Console.WriteLine(Brand+ " "+ Model+ " " + Year + " " + " " + PlateNumber + FueLevel=100 );
        }
        
    }
}