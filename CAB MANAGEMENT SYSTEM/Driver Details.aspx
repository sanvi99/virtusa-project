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
                    <asp:Button ID="Button3" runat="server" Height="32px" OnClick="Button3_Click" Text="Reset" Width="92px" />
                </td>
            </tr>
            <tr>
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
            Id="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <Columns>
                <asp:BoundField DataField="Driver_id" HeaderText="Driver Id" />
                <asp:BoundField DataField="Driver_name" HeaderText="Driver name" />
                <asp:BoundField DataField="Driver_phone" HeaderText="Driver Phone" />
                <asp:BoundField DataField="Driver_email" HeaderText="Driver Email" />
                <asp:BoundField DataField="Cabmodel" HeaderText="Cab Model" />
                <asp:BoundField DataField="Fare" HeaderText="Fare" />
                <asp:BoundField DataField="Location" HeaderText="Location" />
                <asp:CommandField ButtonType="Button" CancelText="" DeleteText="" ShowEditButton="True" />
                <asp:BoundField />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>
</asp:Content>
