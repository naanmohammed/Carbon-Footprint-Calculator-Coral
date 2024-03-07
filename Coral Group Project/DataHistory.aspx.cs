using System;
using System.Collections.Generic;
using System.Linq;

public partial class DataHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {           
            LoadTransportEntries();

            LoadElectricityEntries();

            CalculateAndDisplayTotalCO2Emissions();
        }
    }

    private void LoadTransportEntries()
    {
        if (Session["TransportEntries"] != null)
        {
            List<DataEntryModel> transportEntries = (List<DataEntryModel>)Session["TransportEntries"];

            foreach (var entry in transportEntries)
            {
                entry.CalculateTransportCO2Emissions();
            }

            gvTransportEmissions.DataSource = transportEntries.Select(entry => new
            {
                VehicleType = entry.VehicleType,
                Distance = entry.DistanceType.Equals("Miles") ? entry.ConvertedDistance : entry.Distance.ToString(),
                FuelType = entry.FuelType,
                FuelEfficiency = entry.FuelEfficiencyUnit.Equals("MPG") ? entry.ConvertedFuelEfficiency : entry.FuelEfficiency.ToString(),
                CO2Emissions = entry.CO2Emissions,
                EntryDate = entry.EntryDate
            });
            gvTransportEmissions.DataBind();
        }
    }


    private void LoadElectricityEntries()
    {
        if (Session["ElectricityEntries"] != null)
        {
            List<DataEntryModel> electricityEntries = (List<DataEntryModel>)Session["ElectricityEntries"];

            foreach (var entry in electricityEntries)
            {
                entry.CalculateElectricityCO2Emissions();
            }

            gvElectricityConsumption.DataSource = electricityEntries;
            gvElectricityConsumption.DataBind();
        }
    }

    private void CalculateAndDisplayTotalCO2Emissions()
    {
        double totalCO2Emissions = 0;

        if (Session["TransportEntries"] != null)
        {
            List<DataEntryModel> transportEntries = (List<DataEntryModel>)Session["TransportEntries"];
            totalCO2Emissions += transportEntries.Sum(entry => entry.CO2Emissions);
        }

        if (Session["ElectricityEntries"] != null)
        {
            List<DataEntryModel> electricityEntries = (List<DataEntryModel>)Session["ElectricityEntries"];
            totalCO2Emissions += electricityEntries.Sum(entry => entry.CO2Emissions);
        }

        lblTotalCO2Emissions.Text = totalCO2Emissions.ToString("N2"); 
    }
}
