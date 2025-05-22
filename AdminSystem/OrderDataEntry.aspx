<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter the details of an order below:

        </div> 
        <p>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 46px; position: absolute; width: 121px" Text="Order ID: "></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 147px; top: 40px; position: absolute; bottom: 355px;" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblPlacementDate" runat="server" style="z-index: 1; left: 10px; top: 82px; position: absolute; width: 121px" Text="Placement Date: " height="19px"></asp:Label>
            <asp:TextBox ID="txtPlacementDate" runat="server" style="z-index: 1; left: 147px; top: 75px; position: absolute" height="22px" width="128px"></asp:TextBox>

            <asp:TextBox ID="txtOrderStatus" runat="server" style="z-index: 1; top: 111px; position: absolute; left: 147px" height="22px" width="128px"></asp:TextBox>

            <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 10px; top: 115px; position: absolute" Text="Order Status: " height="19px" width="121px"></asp:Label>
            <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 10px; top: 152px; position: absolute" Text="Total Price: " height="19px" width="121px"></asp:Label>
            <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 147px; top: 147px; position: absolute; height: 22px" width="128px"></asp:TextBox>
 
            <asp:CheckBox ID="chkIsPaid" runat="server" style="z-index: 1; left: 18px; top: 251px; position: absolute" Text="Has been paid: " TextAlign="Left" />
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 10px; top: 220px; position: absolute" Text="Staff ID: " height="19px" width="121px"></asp:Label>

            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 147px; top: 179px; position: absolute" height="22px" width="128px"></asp:TextBox>

        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 185px; position: absolute" Text="Customer ID: " height="19px" width="121px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 147px; top: 214px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 21px; top: 321px; position: absolute" Text="OK" height="26px" width="60px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 282px; position: absolute; right: 503px; bottom: 341px;"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 317px; top: 43px; position: absolute" Text="Find" />
       
            
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="height: 26px; position: absolute; top: 321px; left: 153px; width: 60px;" Text="Cancel" />

        </p>
    </form>
</body>
</html>
