﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <!--TODO: create find button -->
<body style="height: 529px">
    <form id="OrderList" runat="server">
        <div style="height: 518px">
            <asp:ListBox ID="lstOrdersList" runat="server" Height="277px" Width="316px" style="z-index: 1; left: 10px; top: 34px; position: absolute"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="z-index: 1; top: 395px; position: absolute; left: 119px; right: 1269px;" height="26px" width="60px" />
            <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 202px; top: 395px; position: absolute; width: 60px" Text="Delete" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" height="26px" style="z-index: 1; left: 35px; top: 395px; position: absolute; right: 604px;" width="60px" />
            <asp:Label ID="lblOrderStatus" runat="server" Text="Select an Order Status" style="z-index: 1; left: 12px; top: 315px; position: absolute; height: 19px;;"></asp:Label>
            <asp:DropDownList ID="ddlOrderStatus" runat="server" style="z-index: 1; left: 167px; top: 316px; position: absolute;"></asp:DropDownList>
            <asp:Label ID="lblFindOrderID" runat="Server" style="z-index: 1; left: 291px; top: 315px; position: absolute; width: 127px;" Text ="Enter an Order ID : "></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 420px; top: 309px; width: 60px; position: absolute;" height="26px"></asp:TextBox>
           
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 19px; top: 492px; position: absolute"></asp:Label>
            
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" style="z-index: 1; left: 424px; top: 348px; position: absolute; height: 26px; width: 60px;" />
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" style="z-index: 1; left: 35px; top: 348px; position: absolute" height="26px" width="95px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" style="z-index: 1; left: 167px; top: 348px; position: absolute" height="26px" width="95px" />
            <asp:Button ID="btnLogOut" runat ="server" OnClick="btnLogOut_click" Text="Log Out & Return to Main Menu" style="z-index: 1; left: 35px; top: 446px; position: absolute; width: 227px" />
        </div>
    </form>
</body>
</html>
