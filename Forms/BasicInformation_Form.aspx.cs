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
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getTriggers(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getTriggers(Constants.usuario, Constants.bases, Constants.pass);
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
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getFunctions(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getFunctions(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
    }  //ver funciones
    protected void btnProc_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getProcedures(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getProcedures(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
    }  //ver procedimientos
    protected void btnPaquete_Click(object sender, EventArgs e) // ver paquetes
    {
    }
    protected void btnEsquema_Click(object sender, EventArgs e)
    {

    }  //ver todos los esquemas
    protected void btnTableSpace_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getTablespaces(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getTableSpaces(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
    }  //ver los table espaces 
    protected void btnTabla_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getTables(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getTables(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
    }  //ver todas las tablas
    protected void btnSinonimos_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getSynonyms(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getSynonyms(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
    }  //ver todos los sinonimos
    protected void btnVistas_Click(object sender, EventArgs e)
    {
        if (Constants.mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioOracle.getViews(Constants.usuario, Constants.bases, Constants.pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)Constants.servicioSQL.getViews(Constants.usuario, Constants.bases, Constants.pass);
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