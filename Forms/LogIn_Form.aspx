<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Main.master" AutoEventWireup="true" CodeFile="LogIn_Form.aspx.cs" Inherits="Forms_LogIn_Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder2" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <body style="background: url('/Images/background.jpg') repeat 0 0;">
        <div>
            <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">MyDBManager</a>
                </div>
            </nav>
            <div class="container-fluid">
                <form id="LogInForm" runat="server" class="form-horizontal">
                    <fieldset>
                        <!-- Form Name -->
                        <legend>MyDBManager-LogIn</legend>
                        <!-- DataBase Management System-->
                        <div class="control-group">
                            <label class="control-label" for="textinput" >DataBase Management System</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlDatabase" runat="server" CssClass="form-control dropdown-toggle">
                                    <asp:ListItem Value="0">Oracle DataBase</asp:ListItem>
                                    <asp:ListItem Value="1">MSSQL Server DataBase</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <!-- DataBase Instance-->
                        <div class="control-group">
                            <label class="control-label" for="textinput">DataBase</label>
                            <div class="controls">
                                <asp:TextBox ID="txtBase" runat="server" placeholder="DataBase Name" CssClass="form-control input"></asp:TextBox>
                            </div>
                        </div>
                        <!-- DataBase User-->
                        <div class="control-group">
                            <label class="control-label" for="textinput">User</label>
                            <div class="controls">
                                <asp:TextBox ID="txtUser" runat="server" placeholder="UserName" CssClass="form-control input"></asp:TextBox>
                            </div>
                        </div>
                        <!-- DataBase Password-->
                        <div class="control-group">
                            <label class="control-label" for="textinput">Password</label>
                            <div class="controls">
                                <asp:TextBox ID="txtPass" runat="server" type="Password" placeholder="Password" CssClass="form-control input"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <!-- LogIn Button-->
                        <div class="control-group">
                            <div class="controls">
                                <asp:Button ID="btnLogIn" runat="server" Text="LogIn" OnClick="btnLogIn_Click" CssClass="btn btn-primary" />
                            </div>
                        </div>
                    </fieldset>
                </form>
            </div>
        </div>
    </body>
</asp:Content>

