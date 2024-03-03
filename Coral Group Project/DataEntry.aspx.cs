using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataEntry : System.Web.UI.Page
{
    protected void SubmitData(object sender, EventArgs e)
    {
        string vehicleType = ddlVehicleType.SelectedValue;
        double distance = Convert.ToDouble(txtDistance.Text);
        string fuelType = ddlFuelType.SelectedValue;
        double fuelEfficiency = Convert.ToDouble(txtFuelEfficiency.Text);
        string energySource = ddlEnergySource.SelectedValue;
        double electricityUsage = Convert.ToDouble(txtElectricityUsage.Text);

    }
}