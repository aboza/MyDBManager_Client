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
            txtArea.Visible = false;
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getTablespaces(Constants.user, Constants.dataBaseSID, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getTableSpaces(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
            string[] xmlDocument2 = Constants.servicioSQL.getSchemaData(Constants.user, Constants.dataBase, Constants.password);
            txtArea.Text = toString(xmlDocument2);
        }
    }

    private string toString(string[] vStringList)
    {
        string vStringResult = "";
        for (int i = 0; i < vStringList.Length; i++)
        {
            vStringResult = vStringResult + vStringList[i];

        }
        return vStringResult;
    } //convertir una lista a un string

    private void fillGridView(XmlNode vXMLNode)  //llena el data gridview
    {
        XmlDataDocument doc = new XmlDataDocument();
        doc.LoadXml(vXMLNode.OuterXml);
        XmlNodeReader xmlReader = new XmlNodeReader(doc);

        DataSet xmlData = new DataSet();
        xmlData.ReadXml(xmlReader);
        dataTables.DataSource = xmlData.Tables["row"];
        dataTables.DataBind();

        dataError.DataSource = xmlData.Tables["error"];
        dataError.DataBind();
    }

}