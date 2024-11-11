using System;

public class Truck : Vehicle
{
    public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection)
        : base(brand, model, productionDate, lastInspection)
    { }

    public override string InspectionStatus()
    {
        if ((DateTime.Now - ProductionDate).Days > 365 && (DateTime.Now - LastInspection).Days > 365)
        {
            return "The truck needs inspection";
        }
        return "The truck doesnt need inspection.";
    }

    public override string DisplayInfo()
    {
        return $"Truck: {Brand} {Model}";
    }
}
