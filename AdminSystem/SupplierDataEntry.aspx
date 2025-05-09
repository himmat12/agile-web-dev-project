<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1202020/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 315px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblId" runat="server" style="z-index: 1; left: 20px; top: 20px; position: absolute; right: 1096px" Text=" ID"></asp:Label>
        <asp:TextBox ID="txtId" runat="server" style="z-index: 1; left: 140px; top: 20px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 20px; top: 60px; position: absolute; right: 1127px" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 140px; top: 60px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 20px; top: 100px; position: absolute; right: 1131px" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 140px; top: 100px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 20px; top: 140px; position: absolute; right: 1118px" Text="Phone"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 140px; top: 140px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 20px; top: 180px; position: absolute; right: 1116px" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 140px; top: 180px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Style="z-index: 1; left: 20px; top: 220px; position: absolute; right: 1096px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 140px; top: 220px; position: absolute; width: 127px;"></asp:TextBox>
        <br />
        <asp:CheckBox ID="checkActive" runat="server" style="z-index: 1; left: 140px; top: 255px; position: absolute;" Text="Active" height="22px" width="128px" />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 300px; position: absolute; right: 1100px" Text="[lblError]"></asp:Label>
       <br />
        <asp:Button ID="btnCancle" runat="server" style="z-index: 1; left: 23px; top: 338px; position: absolute; width: 84px" Text="Cancle" />
       <br />
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 118px; top: 337px; position: absolute; width: 93px; margin-bottom: 3px" Text="Submit" OnClick="btnSubmit_Click" />
   </form>
</body>
</html>
