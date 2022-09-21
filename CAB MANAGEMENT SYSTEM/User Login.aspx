<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="User Login.aspx.cs" Inherits="CAB_MANAGEMENT_SYSTEM.User_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 43px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2 align="center">User Login</h2>
    <table align="center">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUid" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr >
            <td class="auto-style3">
                </asp:Button>
                <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click1" Text="Login" Width="79px" />
            </td>
            <td class="auto-style3">
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="User Registration.aspx" OnClick="LinkButton2_Click">User Registration</asp:LinkButton>
            </td>
        </tr>

    </table>
     <asp:Label  align="center" ID="Label3" runat="server" ></asp:Label>
    <br />
    
    <a align="center" href="Homepage.aspx"><< Back to Home </a><br />
</asp:Content>
