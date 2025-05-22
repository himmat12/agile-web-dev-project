<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 496px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrdersList" runat="server" Height="277px" Width="316px" OnSelectedIndexChanged="lstOrdersList_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="z-index: 1; top: 327px; position: absolute; left: 96px; right: 499px;" height="26px" width="49px" />
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 176px; top: 327px; position: absolute; width: 49px" Text="Delete" />
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" height="26px" style="z-index: 1; left: 10px; top: 327px; position: absolute" width="49px" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 480px; position: absolute"></asp:Label>
            <asp:Label ID="lblOrderStatus" runat="server" Text="Select an Order Status"></asp:Label>
            <asp:DropDownList ID="ddlOrderStatus" runat="server">
            </asp:DropDownList>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" style="z-index: 1; left: 29px; top: 417px; position: absolute" height="26px" width="95px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" style="z-index: 1; left: 195px; top: 417px; position: absolute" />
        </p>
    </form>
</body>
</html>
