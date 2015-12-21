
using BlogEngine.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;


public partial class catalogo : BlogEngine.Core.Web.Controls.BlogBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Page.Title = Server.HtmlEncode(Resources.labels.catalogo);
        base.AddMetaTag("description", Resources.labels.catalogo + " | " + BlogSettings.Instance.Name);

        lbl_Message.Text = " ";

        loadData("a");

        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra A";
        }
    }
    protected void lbtt_A_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "a";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);

        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra A";
        }
    }
    protected void lbtt_B_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "b";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra B";
        }
    }
    protected void lbtt_C_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "c";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra C";
        }
    }
    protected void lbtt_D_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "d";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra D";
        }
    }
    protected void lbtt_E_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "e";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra E";
        }
    }
    protected void lbtt_F_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "f";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra F";
        }
    }
    protected void lbtt_G_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "g";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra G";
        }
    }
    protected void lbtt_H_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "h";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra H";
        }
    }
    protected void lbtt_I_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "i";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra I";
        }
    }
    protected void lbtt_J_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "j";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra J";
        }
    }
    protected void lbtt_K_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "k";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra K";
        }
    }
    protected void lbtt_L_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "l";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra L";
        }
    }
    protected void lbtt_M_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "m";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra M";
        }
    }
    protected void lbtt_N_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "n";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra N";
        }
    }
    protected void lbtt_Ñ_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "ñ";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra Ñ";
        }
    }
    protected void lbtt_O_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "o";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra O";
        }
    }
    protected void lbtt_P_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "p";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra P";
        }
    }
    protected void lbtt_Q_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "q";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra Q";
        }
    }
    protected void lbtt_R_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "r";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra R";
        }
    }
    protected void lbtt_S_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "s";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra S";
        }
    }
    protected void lbtt_T_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "t";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra T";
        }
    }
    protected void lbtt_U_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "u";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra U";
        }
    }
    protected void lbtt_V_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "v";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra V";
        }
    }
    protected void lbtt_W_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "w";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra W";
        }
    }
    protected void lbtt_X_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "x";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra X";
        }
    }
    protected void lbtt_Y_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "y";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra Y";
        }
    }
    protected void lbtt_Z_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "z";
        lbl_Message.Text = " ";
        loadData(lbl_keyword.Text);
        if (gv_Catalogo.Rows.Count == 0)
        {

            lbl_Message.Text = "No se encontro ninguna coincidencia con la letra Z";
        }
    }
    protected void bttBuscar_Click(object sender, EventArgs e)
    {
        lbl_keyword.Text = "";
        loadData(txtBuscar.Text);
    }
    private void loadData(string keyword)
    {
        try
        {
            DataTable dt = new DataTable();

            lbl_Message.Text = " ";
            Catalogo_Manager n = new Catalogo_Manager();
            dt = n.BrowserCatalogo(keyword);

            gv_Catalogo.DataSource = n.BrowserCatalogo(keyword);

            gv_Catalogo.DataBind();

            lbl_Find.Text = "Resultados encontrados: " + dt.Rows.Count + " con  " + "'" + keyword + "'";
            if (gv_Catalogo.Rows.Count == 0)
            {

                lbl_Message.Text = "No se encontró ningún resultado con " + "'" + txtBuscar.Text + "'";
            }

        }
        catch (SqlException sql)
        {
            lbl_Message.Text = "Error en base de datos:" + sql.Message;
        }
        catch (Exception ex)
        {
            lbl_Message.Text = "Error en capa de datos:" + ex.Message;
        }

    }
    protected void gv_Catalogo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

        gv_Catalogo.PageIndex = e.NewPageIndex;

        if (lbl_keyword.Text.Equals(""))
        {
            loadData(txtBuscar.Text);
        }
        else
        {

            loadData(lbl_keyword.Text);
        }
    }
}

public class Catalogo
{

    public int ID;
    public string Cod_Asig;
    public string curso;
    public string link;
    public string fecha;
    public string cuatri;
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

public class Catalogo_Manager
{
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
            myCommand.Parameters.Add("@date", SqlDbType.NVarChar).Value = obj.fecha;
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