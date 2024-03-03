using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

public partial class DataHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<TransportEmission> transportData = GetDummyTransportData();
            gvTransportEmissions.DataSource = transportData;
            gvTransportEmissions.DataBind();

            List<ElectricityConsumption> electricityData = GetDummyElectricityData();
            gvElectricityConsumption.DataSource = electricityData;
            gvElectricityConsumption.DataBind();
        }
    }

    private List<TransportEmission> GetDummyTransportData()
    {
        List<TransportEmission> data = new List<TransportEmission>();
        data.Add(new TransportEmission("Car", 100, "Gasoline", 30, DateTime.Now.AddDays(-5)));
        data.Add(new TransportEmission("Truck", 200, "Diesel", 20, DateTime.Now.AddDays(-3)));
        data.Add(new TransportEmission("Bus", 150, "Diesel", 15, DateTime.Now.AddDays(-2)));
        data.Add(new TransportEmission("Motorcycle", 50, "Gasoline", 40, DateTime.Now.AddDays(-1)));
        data.Add(new TransportEmission("Bicycle", 0, "None", 0, DateTime.Now.AddDays(-6)));
        data.Add(new TransportEmission("Bajaj", 80, "Gasoline", 35, DateTime.Now.AddDays(-4)));
        data.Add(new TransportEmission("Train", 300, "Electric", 10, DateTime.Now.AddDays(-7)));
        data.Add(new TransportEmission("Electric Car", 120, "Electric", 5, DateTime.Now.AddDays(-9)));
        return data;
    }

    private List<ElectricityConsumption> GetDummyElectricityData()
    {
        List<ElectricityConsumption> data = new List<ElectricityConsumption>();
        data.Add(new ElectricityConsumption("Grid", 500, DateTime.Now.AddDays(-5)));
        data.Add(new ElectricityConsumption("Solar", 200, DateTime.Now.AddDays(-3)));
        data.Add(new ElectricityConsumption("Wind", 300, DateTime.Now.AddDays(-2)));
        data.Add(new ElectricityConsumption("Hydro", 250, DateTime.Now.AddDays(-1)));
        data.Add(new ElectricityConsumption("Waste", 150, DateTime.Now.AddDays(-4)));
        data.Add(new ElectricityConsumption("Geothermal", 350, DateTime.Now.AddDays(-7)));
        data.Add(new ElectricityConsumption("Coal", 600, DateTime.Now.AddDays(-9)));
        data.Add(new ElectricityConsumption("Natural Gas", 450, DateTime.Now.AddDays(-10)));
        return data;
    }
}

public class TransportEmission
{
    public string VehicleType { get; set; }
    public int Distance { get; set; }
    public string FuelType { get; set; }
    public int FuelEfficiency { get; set; }
    public DateTime EntryDate { get; set; }

    public TransportEmission(string vehicleType, int distance, string fuelType, int fuelEfficiency, DateTime entryDate)
    {
        VehicleType = vehicleType;
        Distance = distance;
        FuelType = fuelType;
        FuelEfficiency = fuelEfficiency;
        EntryDate = entryDate;
    }
}

public class ElectricityConsumption
{
    public string EnergySource { get; set; }
    public int ElectricityUsage { get; set; }
    public DateTime EntryDate { get; set; }

    public ElectricityConsumption(string energySource, int electricityUsage, DateTime entryDate)
    {
        EnergySource = energySource;
        ElectricityUsage = electricityUsage;
        EntryDate = entryDate;
    }
}
