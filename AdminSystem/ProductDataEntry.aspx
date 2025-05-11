<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 100px; top: 14px; position: absolute"></asp:TextBox>
        </div>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 99px; top: 39px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 66px; position: absolute" Text="Price"></asp:Label>
        <p>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 100px; top: 69px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCategory" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute; height: 19px; width: 56px" Text="Category"></asp:Label>
        <asp:TextBox ID="txtCategory" runat="server" style="z-index: 1; left: 100px; top: 94px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSize" runat="server" style="z-index: 1; left: 10px; top: 126px; position: absolute" Text="Size"></asp:Label>
        <asp:TextBox ID="txtSize" runat="server" style="z-index: 1; left: 100px; top: 129px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 10px; top: 166px; position: absolute; height: 9px;" Text="Release Date"></asp:Label>
        </p>
        <asp:TextBox ID="txtReleasedDate" runat="server" style="z-index: 1; left: 100px; top: 167px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 106px; top: 253px; position: absolute" Text="In Stock" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 31px; top: 307px; position: absolute; right: 1005px;" Text="OK" height="25px" width="60px" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 307px; position: absolute; height: 25px; left: 120px;" Text="Cancel" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 214px; position: absolute"></asp:Label>
    </form>
</body>
</html>
