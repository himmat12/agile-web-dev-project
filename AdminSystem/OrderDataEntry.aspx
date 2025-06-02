<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 304px">
    <form id="OrderDataEntry" runat="server">
        <div>
            <p>Enter the details of an order below:</p>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 46px; position: absolute; width: 121px" Text="Order ID: "></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 147px; top: 40px; position: absolute; bottom: 355px;" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblPlacementDate" runat="server" style="z-index: 1; left: 10px; top: 82px; position: absolute; width: 121px" Text="Placement Date: " height="19px"></asp:Label>
            <asp:TextBox ID="txtPlacementDate" runat="server" style="z-index: 1; left: 147px; top: 75px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 10px; top: 115px; position: absolute" Text="Order Status: " height="19px" width="121px"></asp:Label>
            <asp:DropDownList ID="ddlOrderStatus" runat="server" style="z-index: 1; left: 147px; top: 114px; position: absolute; width: 133px;" height="22px">
            </asp:DropDownList>
            <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 10px; top: 152px; position: absolute" Text="Total Price: " height="19px" width="121px"></asp:Label>
            <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 147px; top: 147px; position: absolute; height: 22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 185px; position: absolute" Text="Customer ID: " height="19px" width="121px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 147px; top: 179px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 10px; top: 220px; position: absolute" Text="Staff ID: " height="19px" width="121px"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 147px; top: 214px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:CheckBox ID="chkIsPaid" runat="server" style="z-index: 1; left: 18px; top: 251px; position: absolute" Text="Has been paid: " TextAlign="Left" />
       
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 25px; top: 282px; position: absolute; right: 503px; bottom: 341px;"></asp:Label>
        
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 317px; top: 43px; position: absolute" Text="Find" />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" style="z-index: 1; left: 23px; top: 313px; position: absolute; width: 60px; height:25px" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" style="z-index: 1; left: 123px; top: 313px; position: absolute; width: 60px; height:25px"  />
            <asp:Button ID="btnLogOut" runat ="server" OnClick="btnLogOut_click" Text="Log Out & Return to Main Menu" style="z-index: 1; left: 23px; top: 355px; position: absolute; width: 227px" />

        </div>
    </form> 
</body>
</html>
