<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Booked Details.aspx.cs" Inherits="CAB_MANAGEMENT_SYSTEM.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <table class="auto-style1" align="center">
            <tr>
                <td colspan="2">
                    <h1 align="center">Cab Booked </h1>
                </td>
            </tr>
           <br/>
         <br />
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Driver Id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Driver Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Driver Phone"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDpno" runat="server" Height="23px"></asp:TextBox>
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
         </table>
    <br />
    <asp:Label  align="center" ID="Label1" runat="server"></asp:Label>

</asp:Content>
