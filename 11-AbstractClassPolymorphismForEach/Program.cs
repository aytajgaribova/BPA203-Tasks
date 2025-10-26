namespace ConsolApp1;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new(Mercedes, E200, 2023, 4 , 500L , Avtomat, 220);
        Car car2 = new(BMW, 320, 2022, 4 , 480L , Avtomat, 235);
        Car car3 = new(Toyota, Camry, 2021, 4 , 524L , Avtomat, 210);

        Motorcycle motorcycle1 = new(Yamaha, R1, 2023, 998, Sport, yox , 299);
        Motorcycle motorcycle2 = new(Harley - Davidson, 2022, 1868, Cruiser, var, 180);

        Truck truck1 = new(MAN, TGX, 2020, 18, 3, 12, 120);
        Truck truck2 = new(Volvo, FH16, 2021, 25, 4, 18, 110);

        car1.ShowCarInfo();
        car1.CalculateFuelCost(500);
        car2.ShowCarInfo();
        car2.CalculateFuelCost(500);
        car3.ShowCarInfo();
        car3.CalculateFuelCost(500);



        motorcycle1.ShowMotorcycleInfo();
        motorcycle1.CalculateFuelCost(300);
        motorcycle2.ShowMotorcycleInfo();
        motorcycle2.CalculateFuelCost(300);

        truck1.ShowTruckInfo();
        truck1.CalculateFuelCost(800);
        truck1.LoadCargo(5);
        truck2.ShowTruckInfo();
        truck2.CalculateFuelCost(800);
        truck2.LoadCargo(5);

        Console.WriteLine($"Ümumi nəqliyyat sayı: {vehicles.Count}");
        double avgSpeed = vehicles.Average(v =>
           {
               if (v is Car c) return c.MaxSpeed;
               if (v is Motorcycle m) return m.MaxSpeed;
               if (v is Truck t) return t.MaxSpeed;
               return 0;
           });
            Console.WriteLine($"Orta maksimum sürət: {avgSpeed:0.00} km/s");




        




    }
}
