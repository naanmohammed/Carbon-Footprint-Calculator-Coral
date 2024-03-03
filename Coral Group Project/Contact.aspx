<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>How to contact us.</h3>
        <address>
            Team Coral<br />
            Addis Ababa, Ethiopia<br />
            <abbr title="Phone">P:</abbr>
           +25191123456789
        </address>

        <address>
            <strong>Support:</strong>   <a href="teamcoral@azubiafrica.org">teamcoral@azubiafrica.org</a><br />
        </address>
    </main>
</asp:Content>