namespace _11_Abstract_Class
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FueLevel { get; set; }

        public Vehicle(string brand, string model,int year, string plateNumber, double fueLevel=100 )
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.FueLevel = fueLevel;


        }
        public abstract static void GetVehicleInfo();

        public virtual static void ShowBasicInfo()
        {
            System.Console.WriteLine("");
        }
    }
}