<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblTitle" runat="server" Text="Miss Shoes Main Menu" Font-Size="XX-Large" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnSupplier" runat="server" CssClass="auto-style2" height="200px" Text="Supplier Management" width="250px" Font-Size="Medium" OnClick="btnSupplier_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCustomer" runat="server" CssClass="auto-style2" height="200px" Text="Customer Management" width="250px" Font-Size="Medium" OnClick="btnCustomer_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOrder" runat="server" CssClass="auto-style2" Height="200px" Text="Order Management" Width="250px" Font-Size="Medium" OnClick="btnOrder_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnAddress" runat="server" CssClass="auto-style2" height="200px" Text="Address Management" width="250px" Font-Size="Medium" OnClick="btnAddress_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnProduct" runat="server" CssClass="auto-style2" height="200px" Text="Product Management" width="250px" Font-Size="Medium" OnClick="btnProduct_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnStaff" runat="server" CssClass="auto-style2" Height="200px" Text="Staff Management" Width="250px" Font-Size="Medium" OnClick="btnStaff_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
