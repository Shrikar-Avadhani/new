<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/CustomerMaster.Master" CodeBehind="CustComplaint.aspx.vb" Inherits="UdupiElectricityBoard.CustComplaint" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .Complaint {
            display: block;
            width: 800px;
            padding: 20px;
            margin: 30px auto;
        }

        .btn {
            display: block;
            margin: auto;
        }
        
        #form1{
            margin:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="title-heading-w3 text-center mx-auto">
        <h3 class="title-big">Complaints </h3>
    </div>
    <form id="form1" runat="server">
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
            <AlternatingItemTemplate>
                <span style="background-color: #FFFFFF;color: #284775; display: block;
margin: auto;
width: 1000px;">Complaint_Date:
                <asp:Label ID="Complaint_DateLabel" runat="server" Text='<%# Eval("Complaint_Date") %>' />
                <br />
                Complaint:
                <asp:Label ID="ComplaintLabel" runat="server" Text='<%# Eval("Complaint") %>' />
                <br />
<br /></span>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <span style="background-color: #999999; display: block;
margin: auto;
width: 1000px;">Complaint_Date:
                <asp:TextBox ID="Complaint_DateTextBox" runat="server" Text='<%# Bind("Complaint_Date") %>' />
                <br />
                Complaint:
                <asp:TextBox ID="ComplaintTextBox" runat="server" Text='<%# Bind("Complaint") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                <br /><br /></span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <span style="display: block;
margin: auto;
width: 1000px;">Complaint_Date:
                <asp:TextBox ID="Complaint_DateTextBox" runat="server" Text='<%# Bind("Complaint_Date") %>' />
                <br />Complaint:
                <asp:TextBox ID="ComplaintTextBox" runat="server" Text='<%# Bind("Complaint") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                <br /><br /></span>
            </InsertItemTemplate>
            <ItemTemplate>
                <span style="background-color: #E0FFFF;color: #333333; display: block;
margin: auto;
width: 1000px;">Complaint_Date:
                <asp:Label ID="Complaint_DateLabel" runat="server" Text='<%# Eval("Complaint_Date") %>' />
                <br />
                Complaint:
                <asp:Label ID="ComplaintLabel" runat="server" Text='<%# Eval("Complaint") %>' />
                <br />
<br /></span>
            </ItemTemplate>
            <LayoutTemplate>
                <div id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                    <span runat="server" id="itemPlaceholder" />
                </div>
                <div style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF; display: block;
margin: auto;
width: 1000px;">
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <span style="background-color: #E2DED6;font-weight: bold;color: #333333; display: block;
margin: auto;
width: 1000px;">Complaint_Date:
                <asp:Label ID="Complaint_DateLabel" runat="server" Text='<%# Eval("Complaint_Date") %>' />
                <br />
                Complaint:
                <asp:Label ID="ComplaintLabel" runat="server" Text='<%# Eval("Complaint") %>' />
                <br />
<br /></span>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UEBConnectionString23 %>" SelectCommand="SELECT [Complaint], [Complaint_Date] FROM [tblComplaint] WHERE ([Cust_Name] = @Cust_Name)">
            <SelectParameters>
                <asp:SessionParameter Name="Cust_Name" SessionField="CustName" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        
        <textarea style="resize:none;" runat="server" placeholder="Complaints" class="Complaint" id="Complaint" rows="5" cols="100" required=""></textarea>
        <input runat="server" type="submit" value="Submit"  class="btn btn-primary btn-style" onserverclick="Submit" />
    </form>
</asp:Content>

