﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Forms_LogIn_Form : System.Web.UI.Page
{
    //Service References
    OracleService.ORACLEDataAccesService vOracleDataAccesService;
    MSSQLService.MSSQLDataAccesService vMSSQLDataAccessService;

    //OnLoad we instance our dataBase Services
    protected void Page_Load(object sender, EventArgs e)
    {
        vOracleDataAccesService = new OracleService.ORACLEDataAccesService();
        vMSSQLDataAccessService = new MSSQLService.MSSQLDataAccesService();
    }

    //Information complete to procceed
    private Boolean isRequiredInformationComplete()
    {
        if (ddlDatabase.SelectedValue.Equals("0"))
        {
            if (txtBaseSID.Text.Equals("") || txtPass.Text.Equals("") || txtUser.Text.Equals(""))
                return false;
            else
                return true;

        }
        else
        {
            if (txtBase.Text.Equals("") || txtPass.Text.Equals("") || txtUser.Text.Equals(""))
                return false;
            else
                return true;
        }
    }

    //Try to LogIn to MSSSQL or ORACLE with user provided credentials
    private void DoLogIn()
    {
        if (!isRequiredInformationComplete())
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alertMessage", "alert('" + "insufficient information to proceed" + "');", true);
        }
        else
        {
            if (ddlDatabase.SelectedValue.Equals("0"))
            {
                if (vOracleDataAccesService.isLogin(txtUser.Text, txtPass.Text, txtBaseSID.Text))
                {
                    Constants.user = txtUser.Text;
                    Constants.mode = Int32.Parse(ddlDatabase.SelectedValue);
                    Constants.password = txtPass.Text;
                    Constants.dataBase = txtBase.Text;
                    Constants.dataBaseSID = txtBaseSID.Text;
                    Response.Redirect("BasicInformation_Form.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "LogIn Failed for user " + txtUser.Text + "');", true);
                }
            }
            else
            {
                if (vMSSQLDataAccessService.isLogin(txtUser.Text, txtBase.Text, txtPass.Text))
                {
                    Constants.user = txtUser.Text;
                    Constants.mode = Int32.Parse(ddlDatabase.SelectedValue);
                    Constants.password = txtPass.Text;
                    Constants.dataBase = txtBase.Text;
                    Response.Redirect("BasicInformation_Form.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "LogIn Failed for user " + txtUser.Text + "');", true);
                }
            }
        }

    }

    //onClickEvent of LogIn
    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        DoLogIn();

    }



}