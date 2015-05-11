using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Forms_MetaData_Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        divError.Visible = false;
        if (Constants.mode == 0)
            txtArea.Visible = false;
        else
            dataTables.Visible = false;
    }
    protected void btnMetadata_Click(object sender, EventArgs e)
    {
        divError.Visible = false;
        try
        {
            if (Constants.mode == 0)
            {
                XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getMetadata(Constants.user, Constants.dataBaseSID, Constants.password, txtConsult.Text, txtTableSpace.Text);
                fillGridView(xmlDocument);
            }
            else
            {
                if (txtConsult.Text.Equals("view"))
                {
                    string xmlDocument = Constants.servicioSQL.getViewDDL(Constants.user, Constants.dataBase, Constants.password, txtTableSpace.Text);
                    txtArea.Text = xmlDocument;
                }
                else
                {
                    string xmlDocument = Constants.servicioSQL.getTableDDL(Constants.user, Constants.dataBase, Constants.password, txtTableSpace.Text);
                    txtArea.Text = xmlDocument;
                }
            }
        }
        catch (Exception ex)
        {
            divError.Visible = true;
            labelError.Text = ex.Message;
        }
    } //ddl de un objeto
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