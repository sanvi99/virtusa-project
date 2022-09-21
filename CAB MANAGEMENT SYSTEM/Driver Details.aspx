<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Driver Details.aspx.cs" Inherits="CAB_MANAGEMENT_SYSTEM.Driver_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center" class="auto-style3">
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <h1>Driver Details </h1>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Driver Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="DriverPhno"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDpno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="DriverEmail"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDemail" runat="server" Height="23px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="CabModel"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCabmodel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Fare"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFare" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Location"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                </td>
            </tr>
            <caption>
                <br />
            </caption>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Height="30px" OnClick="Button2_Click" Text="Submit" Width="78px" />
                </td>
                <td>
                    <asp:LinkButton ID="lnklogout" runat="server" Font-Size="X-Large" ForeColor="Black" OnClick="lnklogout_Click" style="z-index: 1; left: 843px; top: 232px; position: " Text="LogOut"></asp:LinkButton>
                </td>
            </tr>
        </table>
     <br />
    
    <a align="center" href="Homepage.aspx"><< Back to Home </a><br />
    </div>
    <br />
    <br />
    <div class="row">
        <h4>Driver Details</h4>
        <asp:GridView Class="table table-striped table-bordered"
            Id="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>
