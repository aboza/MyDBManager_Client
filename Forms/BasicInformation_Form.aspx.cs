using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Forms_BasicInformation_Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTrigger_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getTriggers(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getTriggers(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
    }
    private string toString(string[] hola)
    {
        string nuevo = "";
        for (int i = 0; i < hola.Length; i++)
        {
            nuevo = nuevo + hola[i];

        }
        return nuevo;
    } //convertir una lista a un string
    protected void btnFunciones_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getFunctions(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getFunctions(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
    }  //ver funciones
    protected void btnProc_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getProcedures(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getProcedures(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
    }  //ver procedimientos
    protected void btnPaquete_Click(object sender, EventArgs e) // ver paquetes
    {
        if (Constants.mode == 0)
        {
            //ORACLE
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getPackages (Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            // SQL

        }
    }

    protected void btnTableSpace_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getTablespaces(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getTableSpaces(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
    }  //ver los table espaces 
    protected void btnTabla_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getTables(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getTables(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
    }  //ver todas las tablas
    protected void btnSinonimos_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getSynonyms(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getSynonyms(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
    }  //ver todos los sinonimos
    protected void btnVistas_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getViews(Constants.user, Constants.dataBase, Constants.password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getViews(Constants.user, Constants.dataBase, Constants.password);
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