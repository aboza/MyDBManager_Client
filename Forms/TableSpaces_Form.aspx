<%@ Page Language="C#" MasterPageFile="~/Forms/Main.master" AutoEventWireup="true" CodeFile="TableSpaces_Form.aspx.cs" Inherits="Forms_TableSpaces_Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <body style="background: url('/Images/background.jpg') repeat 0 0;">
        <div>
            <div class="container-fluid">
                <form runat="server">
                    <fieldset>
                        <legend>Table Spaces</legend>
                        <asp:Panel runat="server">
                            <div class="table-responsive">
                                <asp:GridView  ID="dataTables" CssClass="table table-bordered table-hover table-striped" runat="server" AllowSorting="True" Enabled="False">
                                </asp:GridView>
                            </div>
                            <asp:GridView  ID="dataError" CssClass="table table-bordered table-hover table-striped" runat="server" AllowSorting="True" Enabled="False">
                            </asp:GridView>
                        </asp:Panel>    
                    </fieldset>
                </form>
            </div>
        </div>
    </body>
</asp:Content>