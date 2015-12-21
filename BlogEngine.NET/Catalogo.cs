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
using System.Runtime.Serialization;
/// <summary>
/// Descripción breve de Catalogo
/// </summary>
///
[DataContract]
public class Catalogo
{
    [DataMember()]
    public int ID;
    [DataMember()]
    public string Cod_Asig;
    [DataMember()]
    public string curso;
    [DataMember()]
    public string link;
    [DataMember()]
    public string fecha;
    [DataMember()]
    public string cuatri;
    [DataMember()]
    public int ID_User;
	public Catalogo()
	{
        this.ID = 0;
        this.Cod_Asig = "";
        this.curso = "";
        this.link = "";
        this.fecha = "";
        this.cuatri = "";
        this.ID_User = 0;
	}
}

public class Catalogo_Manager{
    public int Register(Catalogo obj)
    {
        int ID = 0;
        DataTable dt = Catalogo_ACTION("INSERT", obj);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
            ID = Convert.ToInt32(dr["ID"].ToString());
        }
        return ID;
    }

    public int Update(Catalogo obj)
    {
        int ID = 0;
        DataTable dt = Catalogo_ACTION("UPDATE", obj);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
            ID = Convert.ToInt32(dr["ID"].ToString());
        }
        return ID;
    }

    public int Delete(Catalogo obj)
    {
        int ID = 0;
        DataTable dt = Catalogo_ACTION("DELETE", obj);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
            ID = Convert.ToInt32(dr["ID"].ToString());
        }
        return ID;
    }

    public Catalogo GetByID(Catalogo obj)
    {
        DataTable dt = Catalogo_ACTION("GETBYID", obj);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
            obj = new Catalogo();
            obj.ID = Convert.ToInt32(dr["ID"].ToString());
            obj.Cod_Asig = Convert.ToString(dr["Cod_Asig"].ToString());
            obj.curso = Convert.ToString(dr["Curso"].ToString());
            obj.link = Convert.ToString(dr["link"].ToString());
            obj.fecha = Convert.ToString(dr["fecha"].ToString());
            obj.cuatri = Convert.ToString(dr["cuatri"].ToString());
        }
        return obj;
    }

    public DataTable GetAll()
    {
        return Catalogo_ACTION("GETALL", new Catalogo());
    }
    public DataTable GetByUser(int ID)
    {
        Catalogo user = new Catalogo();
        user.ID_User = ID;
        return Catalogo_ACTION("GETBYUSER", user);
    }
    private SqlConnection GetConnection()
    {
        string cnString = ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString;
        SqlConnection myConnection = new SqlConnection(cnString);
        return myConnection;
    }

    private DataTable Catalogo_ACTION(string Action, Catalogo obj)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlConnection myConnection = GetConnection();
            SqlCommand myCommand = new SqlCommand("DB_Catalogo", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            myCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = Action;
            myCommand.Parameters.Add("@ID", SqlDbType.Int).Value = obj.ID;
            myCommand.Parameters.Add("@Cod", SqlDbType.NVarChar).Value = obj.Cod_Asig;
            myCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = obj.curso;
            myCommand.Parameters.Add("@link", SqlDbType.NVarChar).Value = obj.link;
            myCommand.Parameters.Add("@date", SqlDbType.NVarChar).Value =  obj.fecha;
            myCommand.Parameters.Add("@cuatri", SqlDbType.NVarChar).Value = obj.cuatri;
            myCommand.Parameters.Add("@ID_User", SqlDbType.Int).Value = obj.ID_User;

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

    public DataTable BrowserCatalogo(string Keyword)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlConnection myConnection = GetConnection();
            SqlCommand myCommand = new SqlCommand("BrowserCatalogo", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;


            myCommand.Parameters.Add("@keyword", SqlDbType.NVarChar).Value = Keyword;
         

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