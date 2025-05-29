<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1202020/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    </style>
</head>
<body style="z-index: 1; left: -2px; top: 20px; display:block; position:absolute; height: 96px; width: 1474px">
    

    <form id="form1" runat="server">
        <asp:Label ID="header" style="z-index: 2;" runat="server" Text="Supplier Data Entry" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        <br />
        <asp:Label ID="lblId" runat="server" style="z-index: 2; left: 20px; top: 40px; position: absolute; right: 1357px" Text=" ID"></asp:Label>
        <asp:TextBox ID="txtId" runat="server" style="z-index: 2; left: 140px; top: 40px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblName" runat="server" style="z-index: 2; left: 20px; top: 80px; position: absolute; right: 1385px" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 2; left: 140px; top: 80px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" style="z-index: 2; left: 20px; top: 120px; position: absolute; right: 1360px" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 2; left: 140px; top: 120px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhone" runat="server" style="z-index: 2; left: 20px; top: 160px; position: absolute; right: 1379px" Text="Phone"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 2; left: 140px; top: 160px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" style="z-index: 2; left: 20px; top: 200px; position: absolute; right: 1376px; bottom: 406px;" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 2; left: 140px; top: 200px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Style="z-index: 2; left: 20px; top: 240px; position: absolute; right: 1356px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 2; left: 140px; top: 240px; position: absolute; width: 127px;"></asp:TextBox>
        <br />
        <asp:CheckBox ID="checkActive" runat="server" style="z-index: 2; left: 140px; top: 275px; position: absolute;" Text="Active" height="22px" width="128px" />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 2; left: 20px; top: 300px; position: absolute; right: 536px; height: 19px;" ForeColor="Red"></asp:Label>
       <br />
        <asp:Button ID="btnCancle" runat="server" style="z-index: 2; left: 12px; top: 337px; position: absolute; width: 129px" Text="Cancle" OnClick="btnCancle_Click" />
       <asp:Button ID="btnSubmit" runat="server" style="z-index: 2; left: 149px; top: 337px; position: absolute; width: 129px; margin-bottom: 3px" Text="Submit" OnClick="btnSubmit_Click" />
       <asp:Button ID="btnFind" runat="server" style="z-index: 2; left: 12px; top: 382px; position: absolute; width: 270px; margin-bottom: 3px" Text="Find" OnClick="btnFind_Click" />
       
   </form>
</body>
</html>
