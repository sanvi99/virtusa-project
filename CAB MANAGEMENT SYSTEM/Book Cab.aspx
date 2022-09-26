<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Book Cab.aspx.cs" Inherits="CAB_MANAGEMENT_SYSTEM.Book_Cab" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 355px;
            width: 1509px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
       
        <div align="Center">

             <img src="imgs/onthego.jpg" class="auto-style3" />     
             
        </div>
    <div>
        
      <div>
          <h4>Cab Booking Details</h4>
         
          <br />
          <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
              <Columns>
                  <asp:BoundField DataField="Driver_id" HeaderText="Driver Id" />
                  <asp:BoundField DataField="Driver_name" HeaderText="Driver Name" />
                  <asp:BoundField DataField="Driver_phone" HeaderText="Driver Phone " />
                  <asp:BoundField DataField="cabmodel" HeaderText="Cab Model" />
                  <asp:BoundField DataField="Fare" HeaderText="Fare" />
                  <asp:BoundField DataField="Locations" HeaderText="Location" />
                  <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                  <ControlStyle BackColor="Blue" ForeColor="White" />
                  </asp:CommandField>
              </Columns>
          </asp:GridView>
       </div>
        <div>
            <asp:Label ID="lblFare"  runat="server"></asp:Label>
        </div>
<asp:Button ID="btnRevise" runat="server" OnClick="btnRevise_Click" Text="Revise Search" />&nbsp;
            <asp:LinkButton ID="lnklogout" runat="server" Text="LogOut" OnClick="lnklogout_Click" style="background-color: Yellow; "></asp:LinkButton>
        
        
    </div>
    
</asp:Content>
