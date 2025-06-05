<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier List</title>
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

        .listbox-container {
            margin-bottom: 25px;
        }

        .listbox-styled {
            width: 100%;
            height: 391px;
            border: 2px solid #e5e7eb;
            border-radius: 12px;
            font-size: 1rem;
            font-weight: 700;
            background-color: white;
            padding: 0;
            box-sizing: border-box;
            transition: all 0.3s ease;
        }

        .listbox-styled option {
            padding: 15px 20px;
            border-bottom: 1px solid #e5e7eb;
            background-color: white;
            color: #374151;
            cursor: pointer;
        }

        .listbox-styled option:last-child {
            border-bottom: none;
        }

        .listbox-styled option:hover {
            background-color: #f9fafb;
        }

        .listbox-styled option:selected {
            background-color: #4f46e5;
            color: white;
        }

        .listbox-styled:focus {
            outline: none;
            border-color: #4f46e5;
            background-color: white;
            box-shadow: 0 0 0 3px rgba(79, 70, 229, 0.1);
        }

        .button-group {
            display: flex;
            gap: 15px;
            margin-bottom: 25px;
            justify-content: flex-start;
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
        
        .btn-success {
            padding: 15px 30px;
            background: linear-gradient(135deg, #059669 0%, #10b981 100%);
            color: white;
            border: none;
            border-radius: 12px;
            font-size: 1rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
            min-width: 100px;
        }

        .filter-section {
            background-color: #f9fafb;
            padding: 30px;
            border-radius: 12px;
            border: 1px solid #e5e7eb;
            margin-bottom: 25px;
        }

        .filter-group {
            margin-bottom: 20px;
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
            background-color: white;
            box-sizing: border-box;
            max-width: 300px;
        }

        .form-input:focus {
            outline: none;
            border-color: #4f46e5;
            box-shadow: 0 0 0 3px rgba(79, 70, 229, 0.1);
        }

        .error-label {
            color: #dc2626;
            padding: 12px 16px;
            margin-top: 20px;
            margin-bottom: 20px;
            font-size: 0.9rem;
            font-weight: 700;
            display: block;
        }
        
        .navigation-section {
            border-top: 1px solid #e5e7eb;
            padding-top: 25px;
            margin-top: 25px;
        }
        
        .sized-box{
            height:40px;
        }

        /* Responsive design */
        @media (max-width: 768px) {
            body {
                padding: 20px;
            }

            .page-title {
                font-size: 1.75rem;
                margin-bottom: 40px;
            }

            .button-group {
                flex-direction: column;
            }

            .btn-primary, .btn-secondary, .btn-danger {
                width: 100%;
                margin-bottom: 10px;
            }

            .filter-group {
                margin-bottom: 20px;
            }

            .form-label {
                margin-bottom: 8px;
            }

            .form-input {
                max-width: 100%;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Suppliers List" CssClass="page-title"></asp:Label>
            
            <div class="sized-box"></div>

            <div class="listbox-container">
                <asp:ListBox ID="lstSupplierList" runat="server" CssClass="listbox-styled"></asp:ListBox>
            </div>

            <div class="button-group">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="btn-primary" />
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Edit" CssClass="btn-success" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="btn-danger" />
            </div>
            
            <asp:Label ID="lblError" runat="server" CssClass="error-label"></asp:Label>

            <div class="filter-section">
                <div class="filter-group">
                    <asp:Label ID="Label1" runat="server" Text="Filter by Supplier:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtSupplier" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                
                <div class="button-group">
                    <asp:Button ID="btnFilter" runat="server" Text="Apply Filter" OnClick="btnFilter_Click" CssClass="btn-primary" TabIndex="1" />
                    <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" CssClass="btn-secondary" />
                </div>
            </div>

            <div class="navigation-section">
                <asp:Button ID="btnMainMenu" runat="server" Text="Main Menu" CssClass="btn-secondary" OnClick="btnMainMenu_Click" />
                <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn-danger" OnClick="btnLogout_Click" />
            </div>

        </div>

        
        <script type="text/javascript">
            // auto-clear error message after 3000ms
            window.onload = function() {
                var errorLabel = document.getElementById('<%= lblError.ClientID %>');
                
                if (errorLabel && errorLabel.innerText && errorLabel.innerText.trim() !== '') {
                    setTimeout(function() {
                        errorLabel.innerText = '';
                    }, 3000);
                }
            };
        </script>

    </form>
</body>
</html>