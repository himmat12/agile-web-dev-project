﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 144px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Are you sure you want to delete this record?</p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 10px; top: 91px; position: absolute; width: 90px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; top: 91px; position: absolute; left: 158px; width: 90px" Text="No" />
    </form>
</body>
</html>
