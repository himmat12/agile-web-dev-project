﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="OrderLogin" runat="server">
        <div>
            <p> Order Login Page </p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 30px; position: absolute; top: 82px;" Text="UserName: " height="19px" width="78px"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 117px; position: absolute; top: 82px;" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 30px; top: 131px; position: absolute; right: 1519px" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 117px; top: 127px; position: absolute; right: 1339px;" height="22px" TextMode="Password" width="128px"></asp:TextBox>
            
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 359px; top: 131px; position: absolute"></asp:Label>
            
            <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 30px; top: 182px; position: absolute; height: 22px; width: 62px;" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 30px; top: 217px; position: absolute; height: 22px; width: 151px;" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
            
        
        </div>
    </form>
</body>
</html>
