<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstSupplierList" runat="server" Height="391px" Width="355px" ></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="83px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Edit" Width="83px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="83px" OnClick="btnDelete_Click" />
        </p>
        <p>
            Enter an Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" Width="207px"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 530px; position: absolute; right: 220px; height: 19px;">lsiauhvlidib</asp:Label>
            <asp:Button ID="btnFilter" runat="server" Text="Apply Filter" width="83px" OnClick="btnFilter_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" Width="83px" OnClick="btnClearFilter_Click" />
        </p>
    </form>
</body>
</html>
