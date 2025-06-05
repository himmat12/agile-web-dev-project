<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
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

        .confirm-form {
            background: white;
            padding: 50px;
            border-radius: 20px;
            box-shadow: 0 20px 40px rgba(0, 0, 0, 0.1);
            max-width: 500px;
            width: 100%;
            text-align: center;
        }

        .confirm-message {
            color: #1f2937;
            font-size: 1.2rem;
            font-weight: 600;
            margin-bottom: 60px;
            line-height: 1.6;
        }

        .button-group {
            display: flex;
            gap: 15px;
            justify-content: center;
            flex-wrap: wrap;
        }

        .btn-danger {
            padding: 15px 30px;
            background: linear-gradient(135deg, #dc2626 0%, #ef4444 100%);
            color: white;
            border: none;
            border-radius: 12px;
            font-size: 1rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
            min-width: 100px;
        }

        .btn-secondary {
            padding: 15px 30px;
            background: transparent;
            color: #6b7280;
            border: 2px solid #e5e7eb;
            border-radius: 12px;
            font-size: 1rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
            min-width: 100px;
        }

        /* Responsive design */
        @media (max-width: 768px) {
            body {
                padding: 20px;
            }

            .confirm-form {
                padding: 30px;
            }

            .confirm-message {
                font-size: 1.1rem;
                margin-bottom: 40px;
            }

            .button-group {
                flex-direction: column;
            }

            .btn-danger, .btn-secondary {
                width: 100%;
                margin-bottom: 10px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="confirm-form">
            <div class="confirm-message">
                Are you sure you want to delete this record?
            </div>
            
            <div class="button-group">
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="btn-danger" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="btn-secondary" />
            </div>
        </div>
    </form>
</body>
</html>