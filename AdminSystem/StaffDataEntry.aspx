﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

    <form id="form1" runat="server">
        <div>
            This is the Staff Data Entry Page<asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 75px; top: 47px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" Width="62px" OnClick="BtnFind_Click" />
        </div>
        <p>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 12px; top: 76px; position: absolute; height: 25px" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 77px; top: 71px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; top: 103px; position: absolute; left: 76px" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 15px; top: 110px; position: absolute" Text="Email"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 12px; top: 49px; position: absolute; width: 53px; right: 901px;" Text="Staff ID"></asp:Label>
            <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 12px; top: 138px; position: absolute" Text="Salary"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 76px; top: 135px; position: absolute" height="22px" width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblContactNumber" runat="server" style="z-index: 1; left: 7px; top: 176px; position: absolute" Text="ContactNumber"></asp:Label>
        <asp:TextBox ID="txtContactNumber" runat="server" style="z-index: 1; left: 140px; top: 174px; position: absolute; bottom: 464px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblEmploymentDate" runat="server" style="z-index: 1; left: 9px; top: 224px; position: absolute; width: 114px;" Text="EmploymentDate"></asp:Label>
        <asp:TextBox ID="txtEmploymentDate" runat="server" style="z-index: 1; left: 136px; top: 221px; position: absolute; width: 128px;" height="22px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 284px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
            <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 259px; top: 331px; position: absolute; height: 25px" Text="IsActive" />
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="BtnOk_Click" style="z-index: 1; left: 68px; top: 366px; position: absolute; height: 29px; width: 41px;" Text="Ok" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 155px; top: 368px; position: absolute; right: 453px; height: 24px;" Text="Cancel" OnClick="btnCancel_Click" />
</body>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>

</html>
