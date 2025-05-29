<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 456px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Staff Managment Login Page"></asp:Label>
        <br />
        <br />
        Username:&nbsp;&nbsp;
        <asp:TextBox ID="txtUsername" runat="server" Width="175px"></asp:TextBox>
        <br />
        <br />
        Password:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="174px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="95px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
