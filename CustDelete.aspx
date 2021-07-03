<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminMaster.Master" CodeBehind="CustDelete.aspx.vb" Inherits="UdupiElectricityBoard.CustDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>

.Username{
padding: 10px;
border-radius: 8px;
width: 175px;
        }

.Submit{
padding: 10px;
border-radius: 8px;
width: 140px;
margin: auto;
margin-left: 20px;
        }

.Submit:hover{
    background-color:rgb(173, 12, 20);
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form action="#" id="form1" runat="server">
        <div style="margin:20px auto; width: max-content; ">
             <input id="Username" class="Username" type="text" runat="server" placeholder="Username" />
            <input runat="server" class="Submit" type="submit" id="Submit" value="Delete" onserverclick="Del"/>
        </div>
           

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" Font-Size="Larger" ForeColor="#333333" GridLines="None" Width="1518px" Height="150px" DataKeyNames="Username">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775"/>
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Mobile_No" HeaderText="Mobile_No" SortExpression="Mobile_No" />
            <asp:BoundField DataField="Aadhar_No" HeaderText="Aadhar_No" SortExpression="Aadhar_No" />
            <asp:BoundField DataField="RR_No" HeaderText="RR_No" SortExpression="RR_No" />
            <asp:BoundField DataField="Customer_No" HeaderText="Customer_No" SortExpression="Customer_No" />
            <asp:BoundField DataField="Sub_Division" HeaderText="Sub_Division" SortExpression="Sub_Division" />
            <asp:BoundField DataField="Location_Code" HeaderText="Location_Code" SortExpression="Location_Code" />
            <asp:BoundField DataField="Meter_Code" HeaderText="Meter_Code" SortExpression="Meter_Code" />
            <asp:BoundField DataField="Username" HeaderText="Username" ReadOnly="True" SortExpression="Username" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UEBConnectionString9 %>" SelectCommand="SELECT [Email], [Mobile_No], [Aadhar_No], [RR_No], [Customer_No], [Sub_Division], [Location_Code], [Meter_Code], [Username], [Name], [Address] FROM [tblSignUp]"></asp:SqlDataSource>
    </form>
</asp:Content>
