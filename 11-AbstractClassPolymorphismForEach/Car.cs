namespace _11_Abstract_Class
{
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public int MaxSpeed { get; set; }

        public Car(int DoorsCount, int TrunkCapacity,bool IsAutomatic, int MaxSpeed) : base( brand, model, year,  plateNumber,  fueLevel=100)
        {
            this.DoorsCount = DoorsCount;
            this.TrunkCapacity = TrunkCapacity;
            this.IsAutomatic = IsAutomatic;
            this.MaxSpeed = MaxSpeed;
        }

        public static void ShowCarInfo()
        {
            System.Console.WriteLine(DoorsCount + " " + TrunkCapacity + " " + IsAutomatic + " " + MaxSpeed);
        }
        public static void CalculateFuelCost(double distance )
        {
           (distance / 100) * 4 * 1.50;
        }
        public override void GetVehicleInfo()
        {
            System.Console.WriteLine(Brand+ " "+ Model+ " " + Year + " " + " " + PlateNumber + FueLevel=100 );
        }
        
    }
}