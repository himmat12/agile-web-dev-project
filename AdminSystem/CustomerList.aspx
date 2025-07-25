﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 305px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="276px" Width="304px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p style="height: 37px">
            <asp:Label ID="Label1" runat="server" Text="Enter a Phone Number"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Height="23px"></asp:TextBox>
        </p>
        <p style="height: 37px">
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
            <asp:Button ID="btnApplyFilter" runat="server" Height="37px" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" />
        </p>
    </form>
</body>
</html>
