<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 583px; z-index: 1; left: 0px; top: 0px; position: absolute; width: 1474px">
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Suppliers List" Font-Bold="True" Font-Size="X-Large" style="text-align: center"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ListBox ID="lstSupplierList" runat="server" Height="391px" Width="100%" style="font-weight: 700" ></asp:ListBox>
            <br />
            <br />
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="100px" Height="30px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Edit" Width="100px" Height="30px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="100px" OnClick="btnDelete_Click" Height="30px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Filter an Address:" Height="30px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" Width="220px" Height="30px" Font-Size="Small" style="text-align: left"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnFilter" runat="server" Text="Apply Filter" width="100px" OnClick="btnFilter_Click" Height="30px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" Width="100px" OnClick="btnClearFilter_Click" Height="30px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
