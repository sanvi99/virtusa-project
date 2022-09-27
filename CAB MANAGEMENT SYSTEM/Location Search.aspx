<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Location Search.aspx.cs" Inherits="CAB_MANAGEMENT_SYSTEM.Location_Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 643px;
            height: 227px;
        }
        .auto-style4 {
            width: 188px;
        }
        .auto-style5 {
            width: 188px;
            height: 53px;
        }
        .auto-style6 {
            height: 53px;
        }
        .auto-style7 {
            width: 334px;
        }
        .auto-style8 {
            height: 53px;
            width: 334px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </br>
     <table align="center" class="auto-style1" >
             <tr>
                <td colspan="2">
                    <h1 align="center">  Location Search</h1> 
                </td>
             </tr>
        
            <tr>
                <td class="auto-style4">
                 
                    Source:
                                 
                </td>
                 <td class="auto-style7">
                 
                     <asp:TextBox ID="txtsource" runat="server" Width="332px"></asp:TextBox>
                 
                </td>
            </tr>
             <tr>
                <td class="auto-style4">
                 
                    Destination:

                </td>
                 <td class="auto-style7">
                 
                     <asp:TextBox ID="txtdestination" runat="server" Width="330px"></asp:TextBox>
                 
                </td>
            </tr>
              <tr>
                <td class="auto-style5">
                 
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" Height="42px" Width="147px" />
                
                </td>
                 <td class="auto-style8">
                 
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="search Cabs" Height="38px" Width="155px" />
                 
                </td>
            </tr>
            <tr>
            <td class="auto-style4" >
                <asp:LinkButton ID="lnklogout" runat="server" CssClass="auto-style3" OnClick="lnklogout_Click" style="color: #000000; text-decoration: none;" Text="LogOut"></asp:LinkButton>
            </td>
        </tr>
        
    </table>
     <br />
    
    <a align="center" href="Homepage.aspx"><< Back to Home </a>
    <br />
    <br />
    <h1> Location Search</h1>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="L_id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
         <Columns>
             <asp:BoundField DataField="Locations" HeaderText="Source" />
             <asp:BoundField DataField="Destination" HeaderText="Destination" />
             <asp:CommandField ButtonType="Button" ShowEditButton="True">
             <ControlStyle BackColor="#00CC00" ForeColor="White" />
             </asp:CommandField>
             <asp:CommandField ButtonType="Button" ShowDeleteButton="True">
             <ControlStyle BackColor="Red" ForeColor="White" />
             </asp:CommandField>
         </Columns>
     </asp:GridView>
     <br />
    <div>
    <br />
    <br />
   
        </div>
</asp:Content>

