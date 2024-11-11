using System;

public class Program
{
    public static void Main()
    {
        string carBrand = "Porsche";
        string carModel = "911";
        DateTime carProductionDate = new DateTime(2022, 12, 5);
        DateTime carLastInspection = new DateTime(2024, 8, 9);
        Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);

        string truckBrand = "toyota";
        string truckModel = "truck";
        DateTime truckProductionDate = new DateTime(2022, 12, 5);
        DateTime truckLastInspection = new DateTime(2004, 8, 9);
        Vehicle truck = new Truck(truckBrand, truckModel, truckProductionDate, truckLastInspection);

        Console.WriteLine(car.DisplayInfo());
        Console.WriteLine(car.InspectionStatus());
        Console.WriteLine();
        Console.WriteLine(truck.DisplayInfo());
        Console.WriteLine(truck.InspectionStatus());
    }
}
