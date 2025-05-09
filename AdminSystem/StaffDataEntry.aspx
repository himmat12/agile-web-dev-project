<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

    <form id="form1" runat="server">
        <div>
            This is the Staff Data Entry Page<asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 76px; top: 39px; position: absolute"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 12px; top: 76px; position: absolute; height: 25px" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 75px; top: 76px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; top: 103px; position: absolute; left: 74px"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 15px; top: 110px; position: absolute" Text="Email"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 12px; top: 41px; position: absolute; width: 53px" Text="Staff ID"></asp:Label>
            <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 12px; top: 138px; position: absolute" Text="Salary"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 77px; top: 135px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblContactNumber" runat="server" style="z-index: 1; left: 15px; top: 176px; position: absolute" Text="ContactNumber"></asp:Label>
        <asp:TextBox ID="txtContactNumber" runat="server" style="z-index: 1; left: 134px; top: 173px; position: absolute; bottom: 377px;"></asp:TextBox>
        <asp:Label ID="lblEmploymentDate" runat="server" style="z-index: 1; left: 12px; top: 225px; position: absolute; width: 114px;" Text="EmploymentDate"></asp:Label>
        <asp:TextBox ID="txtEmploymentDate" runat="server" style="z-index: 1; left: 137px; top: 225px; position: absolute; width: 132px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 260px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
            <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 140px; top: 291px; position: absolute; height: 25px" Text="IsActive" />
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="BtnOk_Click" style="z-index: 1; left: 104px; top: 339px; position: absolute" Text="Ok" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 171px; top: 337px; position: absolute; right: 667px;" Text="Cancel" />
    </form>
</body>
</html>
