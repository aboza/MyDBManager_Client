using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Forms_LogIn_Form : System.Web.UI.Page
{
    OracleService.ORACLEDataAccesService servicioOracle;
    MSSQLService.MSSQLDataAccesService servicioSQL;
    protected void Page_Load(object sender, EventArgs e)
    {
        servicioOracle = new OracleService.ORACLEDataAccesService();
        servicioSQL = new MSSQLService.MSSQLDataAccesService();
    }
    protected void btnMetadata_Click(object sender, EventArgs e)
    {
        if (txtBase.Text.Equals("") || txtPass.Text.Equals("") || txtUser.Text.Equals("")) //Se debe llenar todos los campos
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Debe llenar todos los campos" + "');", true);
        }
        else
        {
            if (ddlDatabase.SelectedValue.Equals("0"))
            {
                if (servicioOracle.isLogin(txtUser.Text, txtBase.Text, txtPass.Text))
                {
                    Session["user"] = txtUser.Text;
                    Session["mode"] = ddlDatabase.SelectedValue;
                    Session["password"] = txtPass.Text;
                    Session["bases"] = txtBase.Text;
                    Response.Redirect("MainMenu_Form.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Base, usuario o contraseña incorrectas" + "');", true);
                }
            }
            else
            {
                if (servicioSQL.isLogin(txtUser.Text, txtBase.Text, txtPass.Text))
                {
                    Session["user"] = txtUser.Text;
                    Session["mode"] = ddlDatabase.SelectedValue;
                    Session["password"] = txtPass.Text;
                    Session["bases"] = txtBase.Text;
                    Response.Redirect("MainMenu_Form.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Base, usuario o contraseña incorrectas" + "');", true);
                }
            }
        }
    }



}