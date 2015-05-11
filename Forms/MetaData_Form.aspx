<%@ Page Language="C#" MasterPageFile="~/Forms/Main.master" AutoEventWireup="true" CodeFile="MetaData_Form.aspx.cs" Inherits="Forms_MetaData_Form" %>
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
                                <label class="control-label" for="textinput">Consult</label>
                                <div class="controls">
                                    <asp:TextBox ID="txtTableSpace" runat="server" placeholder="Input the table or view from where you want the meta data" CssClass="form-control input"></asp:TextBox>
                                </div>
                                <label class="control-label" for="textinput">Kind</label>
                                <div class="controls">
                                    <asp:TextBox ID="txtConsult" runat="server" placeholder="Input the kind of element" CssClass="form-control input"></asp:TextBox>
                                </div>
                                <div class="controls">
                                    <asp:Button ID="btnExcPlan" runat="server" Text="Show MetaData" CssClass="btn btn-primary" OnClick="btnMetadata_Click"/>
                                </div>
                            </div>
                            <!-- Result-->
                            <div class="control-group">
                                <label class="control-label" for="textinput">Result</label>
                                <div class="controls">
                                    <asp:TextBox ID="txtArea" TextMode="MultiLine" runat="server" Enabled="false" CssClass="form-control input" Height="150"></asp:TextBox>
                                    <div class="table-responsive">
                                        <asp:GridView CssClass="table table-bordered table-hover table-striped" ID="dataTables" runat="server" Width="1262px"  AllowSorting="True" Enabled="False">
                                        </asp:GridView>
                                    </div>
                                    <div class="table-responsive">
                                        <asp:GridView CssClass="table table-bordered table-hover table-striped" ID="dataError" runat="server" Width="1262px"  AllowSorting="True" Enabled="False">
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