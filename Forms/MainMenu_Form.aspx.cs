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
    string usuario; //usuario de la base
    string pass;    // contraseña
    string bases;   //base de datos a la que se conectara

    protected void Page_Load(object sender, EventArgs e)
    {
        servicioOracle = new OracleService.ORACLEDataAccesService();
        servicioSQL = new MSSQLService.MSSQLDataAccesService();

        mode = Constants.mode;
        usuario = Constants.usuario;
        pass = Constants.pass;
        bases = Constants.bases;

    }
    protected void btnTrigger_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getTriggers(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getTriggers(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
    } // ver los triggers
    protected void btnSesion_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getInfoSesion(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getInfoSesion(usuario, bases, pass);
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
            XmlNode xmlDocument = (XmlNode)servicioOracle.getFunctions(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getFunctions(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
    }  //ver funciones
    protected void btnProc_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getProcedures(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getProcedures(usuario, bases, pass);
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
            XmlNode xmlDocument = (XmlNode)servicioOracle.getTablespaces(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getTableSpaces(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
    }  //ver los table espaces 
    protected void btnTabla_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getTables(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getTables(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
    }  //ver todas las tablas
    protected void btnSinonimos_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getSynonyms(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getSynonyms(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
    }  //ver todos los sinonimos
    protected void btnVistas_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getViews(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getViews(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
    }  //ver todas las vistas
    protected void btnExcOne_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.execCommand(usuario, bases, pass, txtArea.Text);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.execCommand(usuario, bases, pass, txtArea.Text);
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
            XmlNode xmlDocument = (XmlNode)servicioOracle.execCommand(usuario, bases, pass, txtArea.Text);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.execCommand(usuario, bases, pass, txtArea.Text);
            fillGridView(xmlDocument);
        }
    } //ejecutar un query
    protected void btnExcPlan_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.execPlan(usuario, bases, pass, txtArea.Text);
            fillGridView(xmlDocument);
        }
        else
        {
            string xmlDocument = (string)servicioSQL.getExecPlan(usuario, bases, pass, txtArea.Text);
            txtArea.Text = xmlDocument;
        }
    } //plan de ejecucion de un query
    protected void btnMetadata_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getMetadata(usuario, bases, pass, txtTipo.Text, txtTableSpace.Text);
            fillGridView(xmlDocument);
        }
        else
        {
            if (txtTipo.Text.Equals("view"))
            {
                string xmlDocument = servicioSQL.getViewDDL(usuario, bases, pass, txtTableSpace.Text);
                txtArea.Text = xmlDocument;
            }
            else
            {
                string xmlDocument = servicioSQL.getTableDDL(usuario, bases, pass, txtTableSpace.Text);
                txtArea.Text = xmlDocument;
            }
        }

    } //ddl de un objeto
    protected void btnSesionTwo_Click(object sender, ImageClickEventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getInfoSesion(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            XmlNode xmlDocument = (XmlNode)servicioSQL.getInfoSesion(usuario, bases, pass);
            fillGridView(xmlDocument);
        }

    }  //Informacion de la sesion
    protected void btnBasesOne_Click(object sender, EventArgs e)
    {
        if (mode == 0)
        {
            XmlNode xmlDocument = (XmlNode)servicioOracle.getTablespaces(usuario, bases, pass);
            fillGridView(xmlDocument);
        }
        else
        {
            string[] xmlDocument = servicioSQL.getSchemaData(usuario, bases, pass);
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