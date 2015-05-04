<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainMenu_Form.aspx.cs" Inherits="Forms_MainMenu_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .ccolor:hover
         {
             text-decoration: underline;
         }


    </style>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
        $.ajax({
            type: "POST",
            url: "Principal.aspx/fillGridView",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: OnSuccess,
            failure: function (response) {

            },
            error: function (response) {

            }
        });
    });

    function OnSuccess(response) {
    }
</script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="71px" BackColor="#333333" style="margin-left: 0px" Width="1343px">
            
                <asp:Button ID="btnExcPlan" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 27px; left: 880px; width: 92px;" Text="EXC PLAN" CssClass="ccolor" OnClick="btnExcPlan_Click"/>
                <asp:Button ID="btnPaquete" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 26px; left: 108px; width: 82px;" Text="PAQUETES" CssClass="ccolor" OnClick="btnPaquete_Click" />
                <asp:Button ID="btnEsquema" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 26px; left: 199px; width: 92px;" Text="ESQUEMAS" CssClass="ccolor" OnClick="btnEsquema_Click" />
                <asp:Button ID="btnTableSpace" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 26px; left: 296px; width: 110px;" Text="TABLE SPACES" CssClass="ccolor" OnClick="btnTableSpace_Click" />
                <asp:Button ID="btnTabla" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 26px; left: 412px; width: 64px;" Text="TABLAS" CssClass="ccolor" OnClick="btnTabla_Click" />
                <asp:Button ID="btnProc" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 26px; left: 582px; width: 134px;" Text="PROCEDIMIENTOS" CssClass="ccolor" OnClick="btnProc_Click" />
                <asp:Button ID="btnSinonimos" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 26px; left: 722px; width: 84px;" Text="SINONIMOS" CssClass="ccolor" OnClick="btnSinonimos_Click" />
                <asp:Button ID="btnVistas" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 27px; left: 816px; width: 58px;" Text="VISTAS" CssClass="ccolor" OnClick="btnVistas_Click" />
                <asp:Button ID="btnExcOne" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 53px; left: 54px; width: 55px;" Text="Execute" CssClass="ccolor" OnClick="btnExcOne_Click" />
                <asp:ImageButton ID="btnSesionTwo" runat="server" Style="position: absolute; top: 51px; left: 116px; width: 18px;" ImageUrl="~/Images/Administrator-icon.png" OnClick="btnSesionTwo_Click"/>
           
                <asp:Button ID="btnSesion" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 53px; left: 134px; width: 98px; right: 863px; height: 22px;" Text="Sesion actual" CssClass="ccolor" OnClick="btnSesion_Click" />
                <asp:Button ID="btnTrigger" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 26px; left: 23px; width: 82px;" Text="TRIGGERS" CssClass="ccolor" OnClick="btnTrigger_Click" />
                <asp:Button ID="btnBasesOne" runat="server" BackColor="#333333" BorderStyle="None" ForeColor="White" Style="position: absolute; top: 52px; left: 254px; width: 134px;" Text="BASES DE DATOS" CssClass="ccolor" OnClick="btnBasesOne_Click" />
                <asp:ImageButton ID="btnExcTwo" runat="server" ImageUrl="~/Images/btnPlay.png" Style="position: absolute; top: 51px; left: 35px; width: 18px;" OnClick="btnExcTwo_Click" />
                <asp:ImageButton ID="btnBasesTwo" runat="server" BackColor="#333333" ImageUrl="~/Images/Misc-Web-Database-icon.png" Style="position: absolute; top: 52px; left: 233px; width: 18px; bottom: 455px;" OnClick="btnBasesTwo_Click" />
           
                <asp:Button ID="btnFunciones" runat="server" BackColor="#333333" BorderStyle="None" CssClass="ccolor" ForeColor="White" OnClick="btnFunciones_Click" Style="position: absolute; top: 26px; left: 487px; width: 92px;" Text="FUNCIONES" />
           
                <asp:Button ID="btnLogOut" runat="server" BackColor="#333333" BorderStyle="None" CssClass="ccolor" ForeColor="White" Style="position: absolute; top: 28px; left: 1163px; width: 131px;" Text="CERRAR SESION" OnClick="btnLogOut_Click" />
           
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Style="position: absolute; top: 384px; left: 8px; width: 1348px; height: 580px;">
            <asp:GridView ID="dataTables" runat="server" Width="1262px" Style="position: absolute; top: 9px; left: 23px; height: 266px;" AllowSorting="True" Enabled="False">
            </asp:GridView>
            <asp:GridView ID="dataError" runat="server" AllowSorting="True" Enabled="False" Style="position: absolute; top: 297px; left: 23px; height: 266px;" Width="1262px">
            </asp:GridView>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Style="position: absolute; top: 91px; left: 6px; width: 1362px; height: 278px;">
            <asp:TextBox ID="txtArea" runat="server" Height="241px" TextMode="MultiLine" Style="position: absolute; top: 0px; left: 350px; width: 963px;"></asp:TextBox>
            <asp:Button ID="btnMetadata" runat="server" BackColor="#333333" BorderStyle="None" CssClass="ccolor" ForeColor="White" Style="position: absolute; top: 167px; left: 17px; width: 92px; height: 29px;" Text="VER" OnClick="btnMetadata_Click" />
            <asp:TextBox ID="txtTableSpace" runat="server" Style="position: absolute; top: 66px; left: 16px; width: 227px;"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Tipo:" Style="position: absolute; top: 97px; left: 18px;"></asp:Label>
            <asp:Label ID="Label2" runat="server" Style="position: absolute; top: 9px; left: 24px;" Text="METADATA"></asp:Label>
            <asp:TextBox ID="txtTipo" runat="server" Style="position: absolute; top: 124px; left: 17px; width: 227px;"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Style="position: absolute; top: 38px; left: 24px;" Text="Consultar:"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
