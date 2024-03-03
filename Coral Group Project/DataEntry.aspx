<%@ Page Title="Data Entry Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DataEntry.aspx.cs" Inherits="DataEntry" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2>Data Entry Page</h2>

    <div class="row">
        <div class="col-md-6">
            <section id="transportEmissions">
                <h3>Transport Emissions</h3>
                <div class="form-group">
                    <label for="ddlVehicleType">Vehicle Type:</label>
                    <asp:DropDownList runat="server" ID="ddlVehicleType" CssClass="form-control">
                        <asp:ListItem Text="Car" Value="Car" />
                        <asp:ListItem Text="Truck" Value="Truck" />
                        
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="txtDistance">Distance Travelled (miles/kilometers):</label>
                    <asp:TextBox runat="server" ID="txtDistance" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="ddlFuelType">Fuel Type:</label>
                    <asp:DropDownList runat="server" ID="ddlFuelType" CssClass="form-control">
                        <asp:ListItem Text="Gasoline" Value="Gasoline" />
                        <asp:ListItem Text="Diesel" Value="Diesel" />
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="txtFuelEfficiency">Fuel Efficiency (gallons per mile/kilometer):</label>
                    <asp:TextBox runat="server" ID="txtFuelEfficiency" CssClass="form-control"></asp:TextBox>
                </div>
            </section>
        </div>

        <div class="col-md-6">
            <section id="electricityConsumption">
                <h3>Electricity Consumption</h3>
                <div class="form-group">
                    <label for="ddlEnergySource">Energy Source:</label>
                    <asp:DropDownList runat="server" ID="ddlEnergySource" CssClass="form-control">
                        <asp:ListItem Text="Grid" Value="Grid" />
                        <asp:ListItem Text="Solar" Value="Solar" />
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="txtElectricityUsage">Electricity Usage (kWh):</label>
                    <asp:TextBox runat="server" ID="txtElectricityUsage" CssClass="form-control"></asp:TextBox>
                </div>
            </section>
        </div>
    </div>

    <div class="form-group">
        <asp:Button runat="server" OnClick="SubmitData" Text="Submit" CssClass="btn btn-primary" />
    </div>
</asp:Content>
