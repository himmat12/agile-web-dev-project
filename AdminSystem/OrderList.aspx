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
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="z-index: 1; top: 421px; position: absolute; left: 120px; right: 1279px;" height="26px" width="49px" />
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 211px; top: 421px; position: absolute; width: 49px" Text="Delete" />
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" height="26px" style="z-index: 1; left: 24px; top: 421px; position: absolute" width="49px" />
            <asp:Label ID="lblOrderStatus" runat="server" Text="Select an Order Status" style="z-index: 1; left: 23px; top: 330px; position: absolute"></asp:Label>
            <asp:DropDownList ID="ddlOrderStatus" runat="server" style="z-index: 1; left: 192px; top: 329px; position: absolute">
            </asp:DropDownList>
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 480px; position: absolute"></asp:Label>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" style="z-index: 1; left: 19px; top: 369px; position: absolute" height="26px" width="95px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" style="z-index: 1; left: 179px; top: 369px; position: absolute" height="26px" width="95px" />
        </p>
    </form>
</body>
</html>
