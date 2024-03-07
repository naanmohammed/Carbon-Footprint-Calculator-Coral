using System;

public class DataEntryModel
{
    public string VehicleType { get; set; }
    public double Distance { get; set; }
    public string DistanceType { get; set; }
    public string FuelType { get; set; }
    public double FuelEfficiency { get; set; }
    public string FuelEfficiencyUnit { get; set; }
    public string EnergySource { get; set; }
    public double ElectricityUsage { get; set; }
    public double CO2Emissions { get; set; }
    public DateTime EntryDate { get; set; }

    public string ConvertedDistance { get; set; }
    public string ConvertedFuelEfficiency { get; set; }

    public void CalculateTransportCO2Emissions()
    {
        double distanceInKilometers = (DistanceType.Equals("Miles")) ? Distance * 1.60934 : Distance;

        double efficiencyInKilometersPerLiter = (FuelEfficiencyUnit.Equals("MPG")) ? FuelEfficiency * 0.425144 : FuelEfficiency;

        ConvertedDistance = distanceInKilometers.ToString("N2");
        ConvertedFuelEfficiency = efficiencyInKilometersPerLiter.ToString("N2");

        switch (FuelType)
        {
            case "Petrol":
                CO2Emissions = distanceInKilometers / efficiencyInKilometersPerLiter * 2.4;  
                break;
            case "Diesel":
                CO2Emissions = distanceInKilometers / efficiencyInKilometersPerLiter * 2.85;  
                break;
        }
    }

    public void CalculateElectricityCO2Emissions()
    {
        switch (EnergySource)
        {
            case "Solar":
                CO2Emissions = ElectricityUsage * 0.045;  
                break;
            case "Grid":
                CO2Emissions = ElectricityUsage * 0.040;  
                break;
        }
    }
}
