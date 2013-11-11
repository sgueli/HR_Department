using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class employee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strCon = ConfigurationManager.AppSettings["con"] + "User ID=" + Session["user"] + ";Password=" + Session["pwd"];
        string strSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address,  City, Region, PostalCode , Country,  HomePhone, Extension FROM Employees";

        DataSet ds = new DataSet();
        SqlConnection objCon = new SqlConnection(strCon);
        SqlDataAdapter objAd = new SqlDataAdapter(strSQL, objCon);
        objAd.Fill(ds, "employees");

        GridView1.DataSource = ds.Tables["employees"].DefaultView;
        GridView1.DataBind();

        objCon.Close();
        objCon.Dispose();
    }
}