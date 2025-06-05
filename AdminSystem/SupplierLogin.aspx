<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="SupplierLogin" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Management Login</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f8f9fa;
            margin: 0;
            padding: 40px;
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .login-form {
            background: white;
            padding: 50px;
            border-radius: 20px;
            box-shadow: 0 20px 40px rgba(0, 0, 0, 0.1);
            max-width: 450px;
            width: 100%;
        }

        .form-title {
            text-align: center;
            margin-bottom: 60px;
            color: #1f2937;
            font-size: 2rem;
            font-weight: 700;
        }

        .form-group {
            margin-bottom: 25px;
        }

        .form-label {
            display: block;
            margin-bottom: 8px;
            color: #374151;
            font-weight: 600;
            font-size: 0.9rem;
        }

        .form-input {
            width: 100%;
            padding: 15px 20px;
            border: 2px solid #e5e7eb;
            border-radius: 12px;
            font-size: 1rem;
            transition: all 0.3s ease;
            background-color: #f9fafb;
            box-sizing: border-box;
        }

        .form-input:focus {
            outline: none;
            border-color: #4f46e5;
            background-color: white;
            box-shadow: 0 0 0 3px rgba(79, 70, 229, 0.1);
        }

        .btn-primary {
            width: 100%;
            padding: 15px;
            background: linear-gradient(135deg, #4f46e5 0%, #7c3aed 100%);
            color: white;
            border: none;
            border-radius: 12px;
            font-size: 1rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
            margin-bottom: 15px;
        }

        .btn-primary:hover {
            transform: translateY(-2px);
            box-shadow: 0 10px 25px rgba(79, 70, 229, 0.3);
        }

        .btn-secondary {
            width: 100%;
            padding: 15px;
            background: transparent;
            color: #6b7280;
            border: 2px solid #e5e7eb;
            border-radius: 12px;
            font-size: 1rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
        }

        .btn-secondary:hover {
            background-color: #f3f4f6;
            border-color: #d1d5db;
        }

        .error-label {
            color: #dc2626;
            background-color: #fef2f2;
            border: 1px solid #fecaca;
            padding: 12px 16px;
            border-radius: 8px;
            margin-bottom: 20px;
            font-size: 0.9rem;
            display: block;
        }

        .sized-box{
            height:40px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-form">
            <asp:Label ID="Label1" runat="server" Text="Supplier Management Login" CssClass="form-title"></asp:Label>
            <div class="sized-box"></div>
            <asp:Label ID="lblError" runat="server" Text="[lblError]" ForeColor="Red" CssClass="error-label" Visible="false"></asp:Label>
            
            <div class="form-group">
                <label class="form-label">Username:</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label class="form-label">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-input"></asp:TextBox>
            </div>
            
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn-primary" />
            <asp:Button ID="btnCancle" runat="server" Text="Cancel" CssClass="btn-secondary" OnClick="btnCancle_Click" />
        </div>
    </form>
</body>
</html>