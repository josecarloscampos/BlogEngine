using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// Descripción breve de DB_Inicio
/// </summary>
public class DB_Inicio
{

        public string Name;
    public string Description;
 public DB_Inicio()
	{
        this.Name = "";
        this.Description = "";
	}
	
	
}

public class Inicio_Manager {


    public int Register(DB_Inicio obj)
    {
        int ID = 0;
        DataTable dt = DB_Inicio_ACTION("INSERT", obj);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
        }
        return ID;
    }

    public int Update(DB_Inicio obj)
    {
        int ID = 0;
        DataTable dt = DB_Inicio_ACTION("UPDATE", obj);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
        }
        return ID;
    }

    public int Delete(DB_Inicio obj)
    {
        int ID = 0;
        DataTable dt = DB_Inicio_ACTION("DELETE", obj);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
        }
        return ID;
    }

    public DB_Inicio GetByID(DB_Inicio obj)
    {
        DataTable dt = DB_Inicio_ACTION("GETBYID", obj);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
            obj = new DB_Inicio();
            obj.Name = Convert.ToString(dr["NAME"].ToString());
            obj.Description = Convert.ToString(dr["DESCRIPTION"].ToString());
        }
        return obj;
    }

    public DataTable GetAll()
    {
        return DB_Inicio_ACTION("GETALL", new DB_Inicio());
    }

    private SqlConnection GetConnection()
    {
        string cnString = ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(cnString);
        return myConnection;
    }

    private DataTable DB_Inicio_ACTION(string Action, DB_Inicio obj)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlConnection myConnection = GetConnection();
            SqlCommand myCommand = new SqlCommand("DB_Inicio", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            myCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = Action;
            myCommand.Parameters.Add("@NAME", SqlDbType.NVarChar, 150).Value = obj.Name;
            myCommand.Parameters.Add("@DESCRIPTION", SqlDbType.NVarChar).Value = obj.Description;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myConnection.Open();
            myAdapter.Fill(dt);
            myConnection.Close();
        }
        catch (SqlException e) { throw new Exception("Error en base de datos: " + e.Message, e); }
        catch (Exception e) { throw new Exception("Error en Capa de datos: " + e.Message, e); }
        finally { }
        return dt;
    }

}