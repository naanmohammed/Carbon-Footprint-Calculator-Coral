<%@ Page Title="Data History Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DataHistory.aspx.cs" Inherits="DataHistory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="transport-section">
                <h2>Transport Emissions History</h2>
                <asp:GridView ID="gvTransportEmissions" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="VehicleType" HeaderText="Vehicle Type" />
                        <asp:BoundField DataField="Distance" HeaderText="Distance(Km)" />
                        <asp:BoundField DataField="FuelType" HeaderText="Fuel Type" />
                        <asp:BoundField DataField="FuelEfficiency" HeaderText="Fuel Efficiency(Km/L)" />
                        <asp:BoundField DataField="CO2Emissions" HeaderText="CO2 Emissions(Kg)" DataFormatString="{0:#,##0.##}" />
                        <asp:BoundField DataField="EntryDate" HeaderText="Entry Date" />
                    </Columns>
                </asp:GridView>

                <asp:GridView ID="gvElectricityConsumption" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="EnergySource" HeaderText="Energy Source" />
                        <asp:BoundField DataField="ElectricityUsage" HeaderText="Electricity Usage(kWh)" />
                        <asp:BoundField DataField="CO2Emissions" HeaderText="CO2 Emissions(Kg)" DataFormatString="{0:#,##0.##}" />
                        <asp:BoundField DataField="EntryDate" HeaderText="Entry Date" />
                    </Columns>
                </asp:GridView>
            </div>
            <div>
                <h3>Total CO2 Emissions: <asp:Label ID="lblTotalCO2Emissions" runat="server" Text="0.00"></asp:Label> KG</h3>
            </div>
    </div>
</asp:Content>
