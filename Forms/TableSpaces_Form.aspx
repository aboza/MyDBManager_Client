<%@ Page Language="C#" MasterPageFile="~/Forms/Main.master" AutoEventWireup="true" CodeFile="TableSpaces_Form.aspx.cs" Inherits="Forms_TableSpaces_Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <body>
        <div>
            <div class="container-fluid">
                <form runat="server">
                    <fieldset>
                        <legend>Table Spaces</legend>
                        <asp:Panel runat="server">
                            <div class="table-responsive">
                                <asp:GridView  ID="dataTables" Height="150" CssClass="table table-bordered table-hover table-striped" runat="server" AllowSorting="True" Enabled="False">
                                </asp:GridView>
                            </div>
                            <div class="table-responsive">
                                <br />
                                <asp:GridView  ID="dataError" CssClass="table table-bordered table-hover table-striped" runat="server" AllowSorting="True" Enabled="False">
                                </asp:GridView>
                            </div>
                            <br />
                            <label class="control-label" for="textinput">TableSpaces:</label>
                            <asp:TextBox ID="txtArea" runat="server" Enabled="false" CssClass="form-control input"></asp:TextBox>
                        </asp:Panel>    
                    </fieldset>
                </form>
            </div>
        </div>
    </body>
</asp:Content>