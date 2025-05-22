<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 483px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" Height="28px" Text="Find" Width="72px" />
        </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 16px; top: 49px; position: absolute; height: 27px; width: 115px; right: 610px" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 167px; top: 45px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 16px; top: 85px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 16px; top: 124px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 16px; top: 160px; position: absolute" Text="PhoneNumber"></asp:Label>
        <asp:Label ID="lblIsSubscribed" runat="server" style="z-index: 1; left: 16px; top: 200px; position: absolute" Text="IsSubscribed"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 16px; position: absolute; top: 238px" Text="Address"></asp:Label>
        <asp:Label ID="lblCreatedAt" runat="server" style="z-index: 1; left: 16px; top: 267px; position: absolute" Text="CreatedAt"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 167px; top: 82px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 167px; top: 124px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 167px; top: 165px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtIsSubscribed" runat="server" style="z-index: 1; left: 167px; top: 203px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 167px; top: 242px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCreatedAt" runat="server" style="z-index: 1; left: 167px; top: 284px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkIsSubscribed" runat="server" style="z-index: 1; left: 154px; top: 325px; position: absolute" Text="IsSubscribed" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 46px; top: 353px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 53px; top: 398px; position: absolute; width: 58px; height: 24px; right: 588px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 397px; position: absolute; left: 157px; height: 25px;" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
