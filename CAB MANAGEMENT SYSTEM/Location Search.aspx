<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Location Search.aspx.cs" Inherits="CAB_MANAGEMENT_SYSTEM.Location_Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 879px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table runat="server" border="0" cellpadding="0" cellspacing="3" class="auto-style1">
        <tr>
            <td align="right">
                </td>
            <td style="font-weight: 700">Source:&nbsp;
                <input id="txtSource" runat="server" style="width: 200px" type="text" value="" /> &nbsp;
                <br />
                <br />
                Destination:&nbsp;
                <input id="txtDestination" runat="server" style="width: 200px" type="text" value="" />
                <br />
                <br />
                <input onclick="GetRoute()" type="button" value="Get Route" />
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="search Cabs" />
                <asp:LinkButton ID="lnklogout" runat="server" CssClass="auto-style3" OnClick="lnklogout_Click" style="color: #000000" Text="LogOut"></asp:LinkButton>
                <hr />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div id="dvDistance" runat="server">
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div id="dvMap" runat="server" class="auto-style1">
                </div>
            </td>
            <td>
                <div id="dvPanel" runat="server" style="width: 500px; height: 500px">
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
