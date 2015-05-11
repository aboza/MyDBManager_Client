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
    public static string user; //usuario de la base
    public static string password;    // contraseña
    public static string dataBase;   //base de datos a la que se conectara
    public static string dataBaseSID; //SID para ocacle
}