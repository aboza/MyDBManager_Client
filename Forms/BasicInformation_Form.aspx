﻿<%@ Page Language="C#" MasterPageFile="~/Forms/Main.master" AutoEventWireup="true" CodeFile="BasicInformation_Form.aspx.cs" Inherits="Forms_BasicInformation_Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <body style="background: url('/Images/background.jpg') repeat 0 0;">
        <div>
            <div class="container-fluid">
                <form runat="server">
                    <fieldset>
                        <legend>Basic information</legend>
                            <asp:Button ID="btnPaquete" runat="server" Text="Packages" CssClass="btn btn-primary" OnClick="btnPaquete_Click" />
                            <asp:Button ID="btnEsquema" runat="server" Text="Schemes" CssClass="btn btn-primary" OnClick="btnEsquema_Click" />
                            <asp:Button ID="btnTabla" runat="server" Text="Tables" CssClass="btn btn-primary" OnClick="btnTabla_Click" />
                            <asp:Button ID="btnProc" runat="server" Text="Procedures" CssClass="btn btn-primary" OnClick="btnProc_Click" />
                            <asp:Button ID="btnSinonimos" runat="server" Text="Sinonims" CssClass="btn btn-primary" OnClick="btnSinonimos_Click" />
                            <asp:Button ID="btnVistas" runat="server" Text="Views" CssClass="btn btn-primary" OnClick="btnVistas_Click" />
                            <asp:Button ID="btnTrigger" runat="server" Text="Triggers" CssClass="btn btn-primary" OnClick="btnTrigger_Click" />
                            <asp:Button ID="btnFunciones" runat="server" CssClass="btn btn-primary" OnClick="btnFunciones_Click"  Text="Funtions" />
                        <asp:Panel runat="server" ID="prueba">
                            <asp:GridView  ID="dataTables" CssClass="table table-bordered table-hover table-striped" runat="server" AllowSorting="True" Enabled="False">
                            </asp:GridView>
                            <asp:GridView  ID="dataError" CssClass="table table-bordered table-hover table-striped" runat="server" AllowSorting="True" Enabled="False">
                            </asp:GridView>
                        </asp:Panel>
                    </fieldset>
                </form>
            </div>
        </div>
    </body>
</asp:Content>