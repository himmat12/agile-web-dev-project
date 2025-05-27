<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                 <p>Order Login Page </p>
                 <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 30px; position: absolute; top: 82px;" Text="UserName: " height="19px" width="78px"></asp:Label>
                 <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 34px; top: 131px; position: absolute; right: 1519px" Text="Password: "></asp:Label>
                 <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 67px; top: 182px; position: absolute; right: 491px; height: 22px; width: 62px;" Text="Login" OnClick="btnLogin_Click" />
                 <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 202px; top: 182px; position: absolute; height: 22px; width: 62px;" Text="Cancel" />
                 <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 359px; top: 131px; position: absolute"></asp:Label>
                 <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 177px; position: absolute; top: 82px;" height="22px" width="128px"></asp:TextBox>
                 <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 178px; top: 127px; position: absolute; right: 1339px;" height="22px" TextMode="Password" width="128px"></asp:TextBox>
            
        </div>
    </form>
</body>
</html>
