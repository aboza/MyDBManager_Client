<%@ Page MasterPageFile="~/Forms/Main.master" Language="C#" AutoEventWireup="true" CodeFile="Querys_Form.aspx.cs" Inherits="Forms_Querys_Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <body style="background: url('/Images/background.jpg') repeat 0 0;">
        <div>
            <div class="container-fluid">
                <form runat="server">
                    <fieldset>
                        <legend>Querys</legend>
                        <!-- Error message-->
                        <div class="alert alert-danger" id="divError" runat="server">
                            <strong>Error</strong>
                            <asp:Label id="labelError" runat ="server"></asp:Label>
                        </div>
                        <!-- Code for the execution plan-->
                        <div class="control-group">
                            <label class="control-label" for="textinput">Query</label>
                            <div class="controls">
                                <asp:TextBox ID="txtConsult" runat="server" placeholder="Input your query to execute" CssClass="form-control input"></asp:TextBox>
                            </div>
                            <div class="controls">
                                <asp:Button ID="btnExcPlan" runat="server" Text="Execute query" CssClass="btn btn-primary" OnClick="btnExcOne_Click"/>
                            </div>
                        </div>
                        <!-- Result-->
                        <div class="control-group">
                            <label class="control-label" for="textinput">Result</label>
                            <div class="controls">
                                <div class="table-responsive">
                                    <asp:GridView  ID="dataTables" CssClass="table table-bordered table-hover table-striped" runat="server" AllowSorting="True" Enabled="False">
                                    </asp:GridView>
                                </div>
                                <div class="table-responsive">
                                    <asp:GridView  ID="dataError" CssClass="table table-bordered table-hover table-striped" runat="server" AllowSorting="True" Enabled="False">
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </form>
            </div>
        </div>
    </body>
</asp:Content>