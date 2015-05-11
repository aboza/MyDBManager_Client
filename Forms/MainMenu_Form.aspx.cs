using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

public partial class Forms_MainMenu_Form : System.Web.UI.Page
{
    OracleService.ORACLEDataAccesService servicioOracle;
    MSSQLService.MSSQLDataAccesService servicioSQL;
    int mode;
    string user; 
    string password;    
    string dataBase; 
    string dataBaseSID; //SID para ORACLE DataBases

    protected void Page_Load(object sender, EventArgs e)
    {
        servicioOracle = new OracleService.ORACLEDataAccesService();
        servicioSQL = new MSSQLService.MSSQLDataAccesService();

        mode = Constants.mode;
        user = Constants.usuario;
        password = Constants.pass;
        if (mode == 0)
        {
            dataBaseSID = Constants.dataBaseSID;
        }
        else
        {
            dataBase = Constants.bases;
        }
    }

    protected void btnTrigger_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getTriggers(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getTriggers(user, dataBase, password);
            fillGridView(xmlDocument);
        }
    } // ver los triggers
    protected void btnSesion_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getInfoSesion(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getInfoSesion(user, dataBase, password);
            fillGridView(xmlDocument);
        }

    } //ver la informacion de la sesion

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
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getFunctions(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getFunctions(user, dataBase, password);
            fillGridView(xmlDocument);
        }
    }  //ver funciones
    protected void btnProc_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getProcedures(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getProcedures(user, dataBase, password);
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
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getTablespaces(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getTableSpaces(user, dataBase, password);
            fillGridView(xmlDocument);
        }
    }  //ver los table espaces 
    protected void btnTabla_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getTables(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getTables(user, dataBase, password);
            fillGridView(xmlDocument);
        }
    }  //ver todas las tablas
    protected void btnSinonimos_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getSynonyms(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getSynonyms(user, dataBase, password);
            fillGridView(xmlDocument);
        }
    }  //ver todos los sinonimos
    protected void btnVistas_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getViews(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getViews(user, dataBase, password);
            fillGridView(xmlDocument);
        }
    }  //ver todas las vistas
    protected void btnExcOne_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.execCommand(user, dataBaseSID, password, txtArea.Text);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.execCommand(user, dataBase, password, txtArea.Text);
            fillGridView(xmlDocument);
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
    protected void btnExcTwo_Click(object sender, ImageClickEventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.execCommand(user, dataBaseSID, password, txtArea.Text);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.execCommand(user, dataBase, password, txtArea.Text);
            fillGridView(xmlDocument);
        }
    } //ejecutar un query
    protected void btnExcPlan_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.execPlan(user, dataBaseSID, password, txtArea.Text);
            fillGridView(xmlDocument);
        }
        else
        {
            string xmlDocument = (string)servicioSQL.getExecPlan(user, dataBase, password, txtArea.Text);
            txtArea.Text = xmlDocument;
        }
    } //plan de ejecucion de un query
    protected void btnMetadata_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getMetadata(user, dataBaseSID, password, txtTipo.Text, txtTableSpace.Text);
            fillGridView(xmlDocument);
        }
        else
        {
            if (txtTipo.Text.Equals("view"))
            {
                string xmlDocument = servicioSQL.getViewDDL(user, dataBase, password, txtTableSpace.Text);
                txtArea.Text = xmlDocument;
            }
            else
            {
                string xmlDocument = servicioSQL.getTableDDL(user, dataBase, password, txtTableSpace.Text);
                txtArea.Text = xmlDocument;
            }
        }

    } //ddl de un objeto
    protected void btnSesionTwo_Click(object sender, ImageClickEventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getInfoSesion(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getInfoSesion(user, dataBase, password);
            fillGridView(xmlDocument);
        }

    }  //Informacion de la sesion
    protected void btnBasesOne_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getTablespaces(user, dataBaseSID, password);
            fillGridView(xmlDocument);
        }
        else
        {
            string[] xmlDocument = servicioSQL.getSchemaData(user, dataBase, password);
            txtArea.Text = toString(xmlDocument);
        }
    }  //informacion de la base
    protected void btnBasesTwo_Click(object sender, ImageClickEventArgs e)
    {

    }  // informacion de la base con imagen
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("LogIn_Form.aspx");
    }  //cerrar sesion
}