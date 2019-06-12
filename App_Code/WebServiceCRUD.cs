using System; 
using System.Collections.Generic; 
using System.Web; 
using System.Web.Services;
using System.Data.SqlClient;
 
[WebService(Namespace = "http://tempuri.org/")] 
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)] 
public class wsMDW : System.Web.Services.WebService 
{
    public wsMDW () 
    { 
    }
    
    [WebMethod] 
        public string Recuperacion() 
        {
            string strCadSQL;
            string strCadConexion = "user id=nwportal;" +
                                               "password=OydNet.;server=172.25.7.165,56394;" +
                                               "Trusted_Connection=yes;" +
                                               "database=dba2utilsContabilidad; " +
                                               "connection timeout=15";
            SqlConnection myConnection = new SqlConnection(strCadConexion); 
            myConnection.Open();

            //Formar la sentencia SQL, un SELECT en este caso
            SqlDataReader myReader = null;
            strCadSQL = "select * from tblUsuarios with (nolock)";
            SqlCommand myCommand = new SqlCommand(strCadSQL, myConnection);

            //Ejecutar el comando SQL
            myReader = myCommand.ExecuteReader();
            return myReader.ToString();
              
        }
    public string Eliminacion(int ingid)
    {
        string strCadSQL;
        string strCadConexion = "user id=nwportal;" +
                                           "password=OydNet.;server=172.25.7.165,56394;" +
                                           "Trusted_Connection=yes;" +
                                           "database=dba2utilsContabilidad; " +
                                           "connection timeout=15";
        SqlConnection myConnection = new SqlConnection(strCadConexion);
        myConnection.Open();

        SqlDataReader myReader = null;
        strCadSQL = "delete * from tblUsuarios where ingid = "+ingid;
        SqlCommand myCommand = new SqlCommand(strCadSQL, myConnection);

        myReader = myCommand.ExecuteReader();
        return myReader.ToString();
    }
    public string Modificacion (int lngId, string strLogin,string strIdOrganizacion,string strNombre,string strDescripcion,string strClave
        ,DateTime dtmExpiracion,DateTime dtmExpiracionPwd,bool logCambioProxLogin,bool logPuedeCambiarClave,bool logCuentaActiva
        ,bool logClaveNoExpira,int lngMaxLogins,bool logImpersonalizar,bool logAdmin,string strEMail,string strAdsiId
        ,bool logUsrDominio,string strDominio,int lngNroUsuario,int lngTabPorDefecto,string strUsuario,DateTime dtmActualizacion)
    {
        string strCadSQL;
        string strCadConexion = "user id=nwportal;" +
                                           "password=OydNet.;server=172.25.7.165,56394;" +
                                           "Trusted_Connection=yes;" +
                                           "database=dba2utilsContabilidad; " +
                                           "connection timeout=15";
        SqlConnection myConnection = new SqlConnection(strCadConexion);
        myConnection.Open();

        SqlDataReader myReader = null;
        strCadSQL = "update tblusuarios set strLogin= "+strLogin+
        " ,strIdOrganizacion= "+strIdOrganizacion+
        " ,strNombre= "+strNombre+
        " ,strDescripcion= "+strDescripcion+
        " ,strClave= "+strClave+
        " ,dtmExpiracion= "+dtmExpiracion+
        " ,dtmExpiracionPwd= "+dtmExpiracionPwd+
        " ,logCambioProxLogin= "+logCambioProxLogin+
        " ,logPuedeCambiarClave= "+logPuedeCambiarClave+
        " ,logCuentaActiva= "+logCuentaActiva+
        " ,logClaveNoExpira= "+logClaveNoExpira+
        " ,lngMaxLogins= "+lngMaxLogins+
        " ,logImpersonalizar= "+logImpersonalizar+
        " ,logAdmin= "+logAdmin+
        " ,strEMail= "+strEMail+
        " ,strAdsiId= "+strAdsiId+
        " ,logUsrDominio= "+logUsrDominio+
        " ,strDominio= "+strDominio+
        " ,lngNroUsuario= "+lngNroUsuario+
        " ,lngTabPorDefecto= "+lngTabPorDefecto+
        " ,strUsuario= "+strUsuario+
        " ,dtmActualizacion= " + dtmActualizacion + " where ingid=" + lngId;
        SqlCommand myCommand = new SqlCommand(strCadSQL, myConnection);

        myReader = myCommand.ExecuteReader();
        return myReader.ToString();
    }
    public string Insercion(string strLogin, string strIdOrganizacion, string strNombre, string strDescripcion, string strClave
       , DateTime dtmExpiracion, DateTime dtmExpiracionPwd, bool logCambioProxLogin, bool logPuedeCambiarClave, bool logCuentaActiva
       , bool logClaveNoExpira, int lngMaxLogins, bool logImpersonalizar, bool logAdmin, string strEMail, string strAdsiId
       , bool logUsrDominio, string strDominio, int lngNroUsuario, int lngTabPorDefecto, string strUsuario, DateTime dtmActualizacion)
    {
        string strCadSQL;
        string strCadConexion = "user id=nwportal;" +
                                           "password=OydNet.;server=172.25.7.165,56394;" +
                                           "Trusted_Connection=yes;" +
                                           "database=dba2utilsContabilidad; " +
                                           "connection timeout=15";
        SqlConnection myConnection = new SqlConnection(strCadConexion);
        myConnection.Open();

        SqlDataReader myReader = null;
        strCadSQL = "insert into tblusuarios (strLogin,strIdOrganizacion,strNombre,strDescripcion,strClave,dtmExpiracion,dtmExpiracionPwd" +
        ",logCambioProxLogin,logPuedeCambiarClave,logCuentaActiva,logClaveNoExpira,lngMaxLogins,logImpersonalizar,logAdmin,strEMail,strAdsiId,logUsrDominio" +
        ",strDominio,lngNroUsuario,lngTabPorDefecto,lngTabPorDefecto,strUsuario,dtmActualizacion) "
        + "values(" + strLogin + "," + strIdOrganizacion + "," + strNombre + "," + strDescripcion + "," + strClave + "," + dtmExpiracion + "," + dtmExpiracionPwd + "," +
        logCambioProxLogin + "," + logPuedeCambiarClave + "," + logCuentaActiva + "," + logClaveNoExpira + "," + lngMaxLogins + "," + logImpersonalizar + "," +
        logAdmin + "," + strEMail + "," + strAdsiId + "," + logUsrDominio + "," + strDominio + "," + lngNroUsuario + "," + lngTabPorDefecto + "," +
        lngTabPorDefecto + "," + strUsuario + "," + dtmActualizacion + ")";
        
        SqlCommand myCommand = new SqlCommand(strCadSQL, myConnection);

        myReader = myCommand.ExecuteReader();
        return myReader.ToString();
    }
}