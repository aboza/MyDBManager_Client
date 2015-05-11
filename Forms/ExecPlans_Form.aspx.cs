using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Forms_ExecPlans_Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        divError.Visible = false;
        if (Constants.mode == 0)
            txtArea.Visible = false;
        else
            dataTables.Visible = false;
    }
    protected void btnExcPlan_Click(object sender, EventArgs e)
    {
        divError.Visible = false;
        try
        {
            if (Constants.mode == 0)
            {
                XmlNode xmlDocument = Constants.servicioOracle.execPlan(Constants.usuario, Constants.bases, Constants.pass, txtConsult.Text);
                //fillGridView(xmlDocument);
            }
            else
            {
                string xmlDocument = (string)Constants.servicioSQL.getExecPlan(Constants.usuario, Constants.bases, Constants.pass, txtConsult.Text);
                txtArea.Text = xmlDocument;
            }
        }
        catch (Exception ex)
        {
            divError.Visible = true;
            labelError.Text = ex.Message;
        }
    } //plan de ejecucion de un query
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("LogIn_Form.aspx");
    }  //cerrar sesion
    private void fillGridView(XmlNode _xmlNode)  //llena el data gridview
    {
        XmlDataDocument doc = new XmlDataDocument();
        doc.LoadXml(_xmlNode.OuterXml);
        XmlNodeReader xmlReader = new XmlNodeReader(doc);

        DataSet xmlData = new DataSet();
        xmlData.ReadXml(xmlReader);
        dataTables.DataSource = xmlData.Tables["row"];
        dataTables.DataBind();

        dataTables.DataSource = xmlData.Tables["error"];
        dataTables.DataBind();
    }
}