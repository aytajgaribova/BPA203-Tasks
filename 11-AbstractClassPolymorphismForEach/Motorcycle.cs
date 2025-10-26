namespace _11_Abstract_Class
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }

        public Motorcycle(int EngineCapacity, bool HasSidecar, int MaxSpeed, string Type) : base( brand, model, year,  plateNumber,  fueLevel=100)
        {
            this.EngineCapacity = EngineCapacity;
            this.HasSidecar = HasSidecar;
            this.MaxSpeed = MaxSpeed;
            this.Type = Type;

        }
        public static void ShowMotorcycleInfo()
        {
            System.Console.WriteLine(EngineCapacity + " " + HasSider + " " + MaxSpeed+ " " + Type);

        }
        public static void CalculateFuelCost(double distance)
        {
            (distance / 100) * 4 * 1.50;

        }
        public override void GetVehicleInfo()
        {
            System.Console.WriteLine(Brand+ " "+ Model+ " " + Year + " " + " " + PlateNumber + FueLevel=100 );
        }
        
        
        
    }
}