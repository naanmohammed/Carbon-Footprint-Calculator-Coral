<%@ Page Title="Data History Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DataHistory.aspx.cs" Inherits="DataHistory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="transport-section">
        <h2>Transport Emissions History</h2>
        <asp:GridView ID="gvTransportEmissions" runat="server" CssClass="table table-striped"  AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="VehicleType" HeaderText="Vehicle Type" />
                <asp:BoundField DataField="Distance" HeaderText="Distance" />
                <asp:BoundField DataField="FuelType" HeaderText="Fuel Type" />
                <asp:BoundField DataField="FuelEfficiency" HeaderText="Fuel Efficiency" />
                <asp:BoundField DataField="EntryDate" HeaderText="Entry Date" />
            </Columns>
        </asp:GridView>
    </div>
    <div class="electricity-section">
        <h2>Electricity Consumption History</h2>
        <asp:GridView ID="gvElectricityConsumption" runat="server" CssClass="table table-striped"  AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="EnergySource" HeaderText="Energy Source" />
                <asp:BoundField DataField="ElectricityUsage" HeaderText="Electricity Usage" />
                <asp:BoundField DataField="EntryDate" HeaderText="Entry Date" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
