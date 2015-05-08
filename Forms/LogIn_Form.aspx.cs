using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Forms_LogIn_Form : System.Web.UI.Page
{
    //Service References
    OracleService.ORACLEDataAccesService vOracleService;
    MSSQLService.MSSQLDataAccesService vMSSQLService;

    //OnLoad we instance our dataBase Services
    protected void Page_Load(object sender, EventArgs e)
    {
        vOracleService = new OracleService.ORACLEDataAccesService();
        vMSSQLService = new MSSQLService.MSSQLDataAccesService();
    }

    //Information complete to procceed
    private Boolean isRequiredInformationComplete()
    {
        if (txtBase.Text.Equals("") || txtPass.Text.Equals("") || txtUser.Text.Equals(""))
            return false;
        else
            return true;
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
                if (vOracleService.isLogin(txtUser.Text, txtBase.Text, txtPass.Text))
                {
                    Session["user"] = txtUser.Text;
                    Session["mode"] = ddlDatabase.SelectedValue;
                    Session["password"] = txtPass.Text;
                    Session["bases"] = txtBase.Text;
                    Response.Redirect("MainMenu_Form.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "LogIn Failed for user " + txtUser.Text + "');", true);
                }
            }
            else
            {
                if (vMSSQLService.isLogin(txtUser.Text, txtBase.Text, txtPass.Text))
                {
                    Session["user"] = txtUser.Text;
                    Session["mode"] = ddlDatabase.SelectedValue;
                    Session["password"] = txtPass.Text;
                    Session["bases"] = txtBase.Text;
                    Response.Redirect("MainMenu_Form.aspx");
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