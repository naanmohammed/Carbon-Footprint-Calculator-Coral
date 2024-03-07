using System;
using System.Collections.Generic;

public partial class DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitTransportData(object sender, EventArgs e)
    {
        string vehicleType = ddlVehicleType.SelectedValue;
        double distance = Convert.ToDouble(txtDistance.Text);
        string distanceType = ddlDistanceType.SelectedValue;
        string fuelType = ddlFuelType.SelectedValue;
        double fuelEfficiency = Convert.ToDouble(txtFuelEfficiency.Text);
        string fuelEfficiencyUnit = ddlFuelEfficiencyUnit.SelectedValue;

        DataEntryModel transportEntry = new DataEntryModel
        {
            VehicleType = vehicleType,
            Distance = distance,
            DistanceType = distanceType,
            FuelType = fuelType,
            FuelEfficiency = fuelEfficiency,
            FuelEfficiencyUnit = fuelEfficiencyUnit,
            EntryDate = DateTime.Now
        };

        SaveTransportEntryToSession(transportEntry);
    }

    protected void SubmitElectricityData(object sender, EventArgs e)
    {
        string energySource = ddlEnergySource.SelectedValue;
        double electricityUsage = Convert.ToDouble(txtElectricityUsage.Text);

        DataEntryModel electricityEntry = new DataEntryModel
        {
            EnergySource = energySource,
            ElectricityUsage = electricityUsage,
            EntryDate = DateTime.Now
        };

        SaveElectricityEntryToSession(electricityEntry);
    }

    private void SaveTransportEntryToSession(DataEntryModel entry)
    {
        List<DataEntryModel> transportEntries;

        if (Session["TransportEntries"] == null)
        {
            transportEntries = new List<DataEntryModel>();
        }
        else
        {
            transportEntries = (List<DataEntryModel>)Session["TransportEntries"];
        }

        transportEntries.Add(entry);

        Session["TransportEntries"] = transportEntries;
    }

    private void SaveElectricityEntryToSession(DataEntryModel entry)
    {
        List<DataEntryModel> electricityEntries;

        if (Session["ElectricityEntries"] == null)
        {
            electricityEntries = new List<DataEntryModel>();
        }
        else
        {
            electricityEntries = (List<DataEntryModel>)Session["ElectricityEntries"];
        }

        electricityEntries.Add(entry);

        Session["ElectricityEntries"] = electricityEntries;
    }
}
