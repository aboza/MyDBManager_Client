<%@ Page Language="C#" MasterPageFile="~/Forms/Main.master" AutoEventWireup="true" CodeFile="ExecPlans_Form.aspx.cs" Inherits="Forms_ExecPlans_Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <body style="background: url('/Images/background.jpg') repeat 0 0;">
        <div>
            <div class="container-fluid">
                <form runat="server">
                    <fieldset>
                        <legend>Plan de ejecución</legend>
                            <!-- Error message-->
                            <div class="alert alert-danger" id="divError" runat="server">
                                <strong>Error</strong>
                                <asp:Label id="labelError" runat ="server"></asp:Label>
                            </div>
                            <!-- Code for the execution plan-->
                            <div class="control-group">
                                <label class="control-label" for="textinput">Query</label>
                                <div class="controls">
                                    <asp:TextBox ID="txtConsult" runat="server" placeholder="Input your query to create the execution plan" CssClass="form-control input"></asp:TextBox>
                                </div>
                                <div class="controls">
                                    <asp:Button ID="btnExcPlan" runat="server" Text="Show execution plan" CssClass="btn btn-primary" OnClick="btnExcPlan_Click"/>
                                </div>
                            </div>
                            <!-- Result-->
                            <div class="control-group">
                                <label class="control-label" for="textinput">Result</label>
                                <div class="controls">
                                    <asp:TextBox ID="txtArea" runat="server" Enabled="false" CssClass="form-control input"></asp:TextBox>
                                    <asp:GridView CssClass="table table-bordered table-hover table-striped" ID="dataTables" runat="server" Width="1262px"  AllowSorting="True" Enabled="False">
                                    </asp:GridView>
                                </div>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </body>
    </asp:Content>