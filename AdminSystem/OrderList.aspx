<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <!--TODO: create find button -->
<body style="height: 496px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrdersList" runat="server" Height="277px" Width="316px" OnSelectedIndexChanged="lstOrdersList_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="z-index: 1; top: 380px; position: absolute; left: 114px; " height="26px" width="60px" />
        <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 193px; top: 380px; position: absolute; width: 60px" Text="Delete" />
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" height="26px" style="z-index: 1; left: 31px; top: 380px; position: absolute" width="60px" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 480px; position: absolute"></asp:Label>
            <asp:Label ID="lblOrderStatus" runat="server" Text="Select an Order Status" style="z-index: 1; left: 10px; top: 300px; position: absolute"></asp:Label>
            <asp:DropDownList ID="ddlOrderStatus" runat="server" style="z-index: 1; left: 170px; top: 300px; position: absolute"> 
            </asp:DropDownList>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" style="z-index: 1; left: 32px; top: 335px; position: absolute" height="26px" width="95px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" style="z-index: 1; left: 164px; top: 335px; position: absolute" height="26px" width="95px" />
        </p>
    </form>
</body>
</html>
