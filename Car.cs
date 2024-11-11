using System;

public class Car : Vehicle
{
    public Car(string brand, string model, DateTime productionDate, DateTime lastInspection)
        : base(brand, model, productionDate, lastInspection)
    { }

    public override string InspectionStatus()
    {
        if ((DateTime.Now - ProductionDate).Days > 365 * 4 && (DateTime.Now - LastInspection).Days > 365 * 2)
        {
            return "The car needs inspection";
        }
        return "The car doesnt need inspection";
    }

    public override string DisplayInfo()
    {
        return $"Car: {Brand} {Model}";
    }
}
