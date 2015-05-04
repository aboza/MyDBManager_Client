<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn_Form.aspx.cs" Inherits="Forms_LogIn_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript"></script>
</head>
<body>
    <form id="LogInForm" runat="server">
        <div>
        </div>
        <asp:Panel ID="LogInFormPanel1" runat="server" Style="position: absolute; top: 91px; left: 6px; width: 1362px; height: 396px;">
            <asp:Button ID="btnMetadata" runat="server" BackColor="#333333" BorderStyle="None" CssClass="ccolor" ForeColor="White" Style="position: absolute; top: 290px; left: 15px; width: 137px; height: 29px;" Text="LogIn" OnClick="btnMetadata_Click" />
            <asp:TextBox ID="txtUser" runat="server" Style="position: absolute; top: 66px; left: 16px; width: 227px;"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Password" Style="position: absolute; top: 97px; left: 18px;"></asp:Label>
            LogIn
            <asp:Label ID="Label3" runat="server" Style="position: absolute; top: 38px; left: 24px;" Text="User"></asp:Label>
            <asp:Label ID="Label4" runat="server" Style="position: absolute; top: 157px; left: 23px;" Text="DataBase"></asp:Label>
            <asp:TextBox ID="txtPass" runat="server" Style="position: absolute; top: 124px; left: 17px; width: 227px;"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Style="position: absolute; top: 214px; left: 23px;" Text="DataBase Management System"></asp:Label>
            <asp:TextBox ID="txtBase" runat="server" Style="position: absolute; top: 183px; left: 15px; width: 227px;"></asp:TextBox>
            <asp:DropDownList ID="ddlDatabase" runat="server" Style="position: absolute; top: 238px; left: 15px; height: 32px; width: 221px; margin-top: 7px;">
                <asp:ListItem Value="0">Oracle DataBase</asp:ListItem>
                <asp:ListItem Value="1">MSSQL Server DataBase</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
    </form>
</body>
</html>
