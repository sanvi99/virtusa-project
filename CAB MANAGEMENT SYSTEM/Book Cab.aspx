<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Book Cab.aspx.cs" Inherits="CAB_MANAGEMENT_SYSTEM.Book_Cab" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 363px;
        }
        .auto-style2 {
            height: 363px;
            width: 102%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
       
        <div align="Center">

             <img src="imgs/onthego.jpg" class="auto-style2" />     
             
        </div>
        <br />
    <br />

    <div>
        
      <div>
          <h4>Cab Booking Details</h4>
           <asp:GridView ID="GridView1"   AutoGenerateColumns="false"    runat="server" 
               DataKeyNames="CabID,DriverId,DriverEmail,DriverPhno,fare" OnRowCommand="GridView1_RowCommand">
               <Columns>
                   <asp:BoundField HeaderText="CabModel" DataField="CabModel" />
                   <asp:BoundField HeaderText="Fare PER KM" DataField="fare" />
                   <asp:BoundField HeaderText="Locaion" DataField="Locaion" />
                   <asp:BoundField HeaderText="DriverName" DataField="DriverName" />                 
                   <asp:BoundField HeaderText="DriverPhno" DataField="DriverPhno" />
                   <asp:TemplateField>
                       <ItemTemplate>
                           <asp:LinkButton ID="LinkButton1" runat="server" CommandName="SelectCab">Select</asp:LinkButton>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:BoundField Visible="false" DataField="DriverEmail" />
                                  

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
