using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string strCon = ConfigurationManager.AppSettings["con"] + "User ID=" + txtFirst.Value + ";Password=" + txtPassword.Value;
        SqlConnection con = new SqlConnection();
        try
        {
            con.ConnectionString = strCon;
            con.Open();
        }
        catch (Exception ex)
        {
            rtn.InnerHtml = "Invalid Login:<br />Message - " + ex.Message + "<br />Source - " + ex.Source;
        }

        if (con.State == System.Data.ConnectionState.Open)
        {
            Session["user"] = txtFirst.Value;
            Session["pwd"] = txtPassword.Value;
            Response.Redirect("employee.aspx");
        }
        else
        {
            if (rtn.InnerHtml == "")
            {
                rtn.InnerHtml = "Invalid Login";
            }
        }
        con.Close();
        con.Dispose();
    }
}