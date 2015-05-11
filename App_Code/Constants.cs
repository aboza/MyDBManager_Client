using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Constants
/// </summary>
public static class Constants
{
    public static OracleService.ORACLEDataAccesService servicioOracle = new OracleService.ORACLEDataAccesService();
    public static MSSQLService.MSSQLDataAccesService servicioSQL = new MSSQLService.MSSQLDataAccesService();
    public static int mode;
    public static string usuario; //usuario de la base
    public static string pass;    // contraseña
    public static string bases;   //base de datos a la que se conectara
    public static string dataBaseSID; //SID para ocacle
}