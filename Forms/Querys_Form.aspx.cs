using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Forms_Querys_Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        divError.Visible = false;
    }
    protected void btnExcOne_Click(object sender, EventArgs e)
    {
        divError.Visible = false;
        try
        {
            if (Constants.mode == 0)
            {
                XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.execCommand(Constants.user, Constants.dataBaseSID, Constants.password, txtConsult.Text);
                fillGridView(xmlDocument);
            }
            else
            {
                XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.execCommand(Constants.user, Constants.dataBase, Constants.password, txtConsult.Text);
                fillGridView(xmlDocument);
            }
        }
        catch (Exception ex)
        {
            divError.Visible = true;
            labelError.Text = ex.Message;
        }
    }  //ejecutar un querry
    private void fillGridView(XmlNode _xmlNode)  //llena el data gridview
    {
        XmlDataDocument doc = new XmlDataDocument();
        doc.LoadXml(_xmlNode.OuterXml);
        XmlNodeReader xmlReader = new XmlNodeReader(doc);

        DataSet xmlData = new DataSet();
        xmlData.ReadXml(xmlReader);
        dataTables.DataSource = xmlData.Tables["row"];
        dataTables.DataBind();

        dataError.DataSource = xmlData.Tables["error"];
        dataError.DataBind();
    }
}