<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Miss Shoes Main Menu</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f8f9fa;
            margin: 0;
            padding: 40px;
            min-height: 100vh;
            max-width: 1200px;
            margin: 0 auto;
            padding: 40px;
        }

        .page-title {
            text-align: center;
            margin-bottom: 80px;
            color: #1f2937;
            font-size: 2.5rem;
            font-weight: 700;
        }

        .main-wrapper{
            justify-items:center;
        }

        .menu-container {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
            gap: 30px;
            max-width: 1000px;
            margin: 0 auto;
        }

        .menu-button {
            padding: 40px 30px;
            background: linear-gradient(135deg, #4f46e5 0%, #7c3aed 100%);
            color: white;
            border: none;
            border-radius: 20px;
            font-size: 1.2rem;
            font-weight: 700;
            cursor: pointer;
            transition: all 0.3s ease;
            min-height: 200px;
            display: flex;
            align-items: center;
            justify-content: center;
            text-align: center;
            box-shadow: 0 10px 30px rgba(79, 70, 229, 0.2);
        }

        .menu-button:nth-child(2) {
            background: linear-gradient(135deg, #059669 0%, #10b981 100%);
            box-shadow: 0 10px 30px rgba(5, 150, 105, 0.2);
        }

        .menu-button:nth-child(3) {
            background: linear-gradient(135deg, #dc2626 0%, #ef4444 100%);
            box-shadow: 0 10px 30px rgba(220, 38, 38, 0.2);
        }

        .menu-button:nth-child(4) {
            background: linear-gradient(135deg, #7c2d12 0%, #ea580c 100%);
            box-shadow: 0 10px 30px rgba(124, 45, 18, 0.2);
        }

        .menu-button:nth-child(5) {
            background: linear-gradient(135deg, #7c3aed 0%, #a855f7 100%);
            box-shadow: 0 10px 30px rgba(124, 58, 237, 0.2);
        }

        /* Responsive design */
        @media (max-width: 768px) {
            body {
                padding: 20px;
            }

            .page-title {
                font-size: 2rem;
                margin-bottom: 60px;
            }

            .menu-container {
                grid-template-columns: 1fr;
                gap: 20px;
            }

            .menu-button {
                min-height: 120px;
                padding: 30px 20px;
                font-size: 1.1rem;
            }
        }

        @media (max-width: 480px) {
            .page-title {
                font-size: 1.75rem;
            }

            .menu-button {
                min-height: 100px;
                padding: 25px 15px;
                font-size: 1rem;
            }
        }
        
        .sized-box{
            height:40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-wrapper">
            <asp:Label ID="lblTitle" runat="server" Text="Miss Shoes Admin" CssClass="page-title"></asp:Label>
            <div class="sized-box"></div>
            <div class="menu-container">
                <asp:Button ID="btnSupplier" runat="server" Text="Supplier Management" 
                    CssClass="menu-button" OnClick="btnSupplier_Click" />
                
                <asp:Button ID="btnCustomer" runat="server" Text="Customer Management" 
                    CssClass="menu-button" OnClick="btnCustomer_Click" />
                
                <asp:Button ID="btnOrder" runat="server" Text="Order Management" 
                    CssClass="menu-button" OnClick="btnOrder_Click" />
                
                <asp:Button ID="btnProduct" runat="server" Text="Product Management" 
                    CssClass="menu-button" OnClick="btnProduct_Click" />
                
                <asp:Button ID="btnStaff" runat="server" Text="Staff Management" 
                    CssClass="menu-button" OnClick="btnStaff_Click" />
            </div>
        </div>
    </form>
</body>
</html>