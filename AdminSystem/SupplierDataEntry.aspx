<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Data Entry</title>
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
            margin-bottom: 60px;
            color: #1f2937;
            font-size: 2rem;
            font-weight: 700;
        }

        .form-container {
            background: white;
            padding: 50px;
            border-radius: 20px;
            box-shadow: 0 20px 40px rgba(0, 0, 0, 0.1);
            max-width: 600px;
            margin: 0 auto;
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

        .checkbox-container {
            display: flex;
            align-items: center;
            margin-bottom: 25px;
        }

        .form-checkbox {
            margin-right: 10px;
            transform: scale(1.2);
            accent-color: #4f46e5;
        }

        .checkbox-label {
            color: #374151;
            font-weight: 600;
            font-size: 0.9rem;
            cursor: pointer;
        }

        .button-group {
            display: flex;
            gap: 15px;
            margin-bottom: 25px;
            justify-content: center;
            flex-wrap: wrap;
        }

        .btn-primary {
            padding: 15px 30px;
            background: linear-gradient(135deg, #4f46e5 0%, #7c3aed 100%);
            color: white;
            border: none;
            border-radius: 12px;
            font-size: 1rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
            flex: 1;
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
            flex: 1;
        }

        .btn-find {
            padding: 15px 30px;
            background: linear-gradient(135deg, #059669 0%, #10b981 100%);
            color: white;
            border: none;
            border-radius: 12px;
            font-size: 1rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
            width: 100%;
            margin-top: 10px;
        }

        .error-label {
            color: #dc2626;
            margin-bottom: 20px;
            font-size: 0.9rem;
            font-weight: 700;
            display: block;
        }
        
        .sized-box{
            height:40px;
        }

        /* Responsive design */
        @media (max-width: 768px) {
            body {
                padding: 20px;
            }

            .form-container {
                padding: 30px;
            }

            .page-title {
                font-size: 1.75rem;
                margin-bottom: 40px;
            }

            .button-group {
                flex-direction: column;
            }

            .btn-primary, .btn-secondary {
                width: 100%;
                margin-bottom: 10px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            
            <div class="form-container">
            <asp:Label ID="header" runat="server" Text="Supplier Data Entry" CssClass="page-title"></asp:Label>
                <div class="sized-box"></div>
                <div class="form-group">
                    <asp:Label ID="lblId" runat="server" Text="ID" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtId" runat="server" CssClass="form-input"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblName" runat="server" Text="Name" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-input"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblEmail" runat="server" Text="Email" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-input"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblPhone" runat="server" Text="Phone" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPhone" runat="server" CssClass="form-input"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblAddress" runat="server" Text="Address" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtAddress" runat="server" CssClass="form-input"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtDateAdded" runat="server" CssClass="form-input"></asp:TextBox>
                </div>

                <div class="checkbox-container">
                    <asp:CheckBox ID="checkActive" runat="server" CssClass="form-checkbox" />
                    <label for="<%= checkActive.ClientID %>" class="checkbox-label">Active</label>
                </div>

                <asp:Label ID="lblError" runat="server" CssClass="error-label"></asp:Label>

                <div class="button-group">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn-primary" />
                    <asp:Button ID="btnCancle" runat="server" Text="Cancel" OnClick="btnCancle_Click" CssClass="btn-secondary" />
                </div>

                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn-find" />
            </div>

       
    </form>
</body>
</html>