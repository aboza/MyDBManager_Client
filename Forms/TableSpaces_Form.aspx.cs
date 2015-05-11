using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Forms_TableSpaces_Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getTablespaces(Constants.user, Constants.dataBaseSID, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getTableSpaces(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
    }
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