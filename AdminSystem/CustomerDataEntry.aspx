<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 16px; top: 49px; position: absolute; height: 27px; width: 115px; right: 610px" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 152px; top: 45px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblNameId" runat="server" style="z-index: 1; left: 20px; top: 85px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="lblEmailId" runat="server" style="z-index: 1; left: 22px; top: 124px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblPhoneNumberId" runat="server" style="z-index: 1; left: 22px; top: 160px; position: absolute" Text="PhoneNumber"></asp:Label>
        <asp:Label ID="lblIsSubscribedId" runat="server" style="z-index: 1; left: 28px; top: 200px; position: absolute" Text="IsSubscribed"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 28px; position: absolute; top: 238px" Text="Address"></asp:Label>
        <asp:Label ID="lblCreatedAtId" runat="server" style="z-index: 1; left: 26px; top: 267px; position: absolute" Text="CreatedAt"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 154px; top: 82px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 156px; top: 124px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 160px; top: 165px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtIsSubscribed" runat="server" style="z-index: 1; left: 161px; top: 203px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 167px; top: 242px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCreatedAt" runat="server" style="z-index: 1; left: 165px; top: 284px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkIsSubscribed" runat="server" style="z-index: 1; left: 155px; top: 350px; position: absolute" Text="IsSubscribed" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 62px; top: 390px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 194px; top: 388px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 391px; position: absolute; left: 268px" Text="Cancel" />
    </form>
</body>
</html>
