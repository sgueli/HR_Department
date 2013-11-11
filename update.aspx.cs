using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loadEmployee(); 
           
            
        }
    }
    private void loadEmployee()
    {
        string strCon = ConfigurationManager.AppSettings["con"] + "User ID=" + Session["user"] + ";Password=" + Session["pwd"];
        string sql = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address,  City, Region, PostalCode , Country,  HomePhone, Extension FROM Employees WHERE EmployeeID=1";

        SqlConnection con = new SqlConnection();
        con.ConnectionString = strCon;
        con.Open();
        SqlCommand objCmd = new SqlCommand(sql, con);
        SqlDataReader objRd = objCmd.ExecuteReader();

        if (objRd.Read())
        {
            if (object.ReferenceEquals(objRd["EmployeeID"], System.DBNull.Value))
            {
                this.txtID.Text = "N/A";
            }
            else
            {
                this.txtID.Text = objRd["EmployeeID"].ToString();
            }
            if (object.ReferenceEquals(objRd["EmployeeID"], System.DBNull.Value))
            {
                this.txtID.Text = "N/A";
            }
            else
            {
                this.txtLastName.Text = objRd["LastName"].ToString();
            }
            if (object.ReferenceEquals(objRd["LastName"], System.DBNull.Value))
            {
                this.txtLastName.Text = "N/A";
            }
            else
            {
                {
                    this.txtLastName.Text = objRd["LastName"].ToString();
                }
            }
            if (object.ReferenceEquals(objRd["FirstName"], System.DBNull.Value))
            {
                this.txtFirstName.Text = "N/A";
            }
            else
            {
                {
                    this.txtFirstName.Text = objRd["FirstName"].ToString();
                }
            }

            if (object.ReferenceEquals(objRd["Title"], System.DBNull.Value))
            {
                this.txtTitle.Text = "N/A";
            }
            else
            {
                {
                    this.txtTitle.Text = objRd["Title"].ToString();
                }
            }
            if (object.ReferenceEquals(objRd["TitleOfCourtesy"], System.DBNull.Value))
            {
                this.txtTitleOfCourtesy.Text = "N/A";
            }
            else
            {
                {
                    this.txtTitleOfCourtesy.Text = objRd["TitleOfCourtesy"].ToString();
                }
            }

            if (object.ReferenceEquals(objRd["BirthDate"], System.DBNull.Value))
            {
                this.txtBirthDate.Text = "N/A";
            }
            else
            {
                {
                    this.txtBirthDate.Text = objRd["BirthDate"].ToString();
                }
            }

            if (object.ReferenceEquals(objRd["HireDate"], System.DBNull.Value))
            {
                this.txtHireDate.Text = "N/A";
            }
            else
            {
                {
                    this.txtHireDate.Text = objRd["HireDate"].ToString();
                }
            }

            if (object.ReferenceEquals(objRd["Address"], System.DBNull.Value))
            {
                this.txtAddress.Text = "N/A";
            }
            else
            {
                {
                    this.txtAddress.Text = objRd["Address"].ToString();
                }
            }


            if (object.ReferenceEquals(objRd["City"], System.DBNull.Value))
            {
                this.txtCity.Text = "N/A";
            }
            else
            {
                {
                    this.txtCity.Text = objRd["City"].ToString();
                }
            }


            if (object.ReferenceEquals(objRd["Region"], System.DBNull.Value))
            {
                this.txtRegion.Text = "N/A";
            }
            else
            {
                {
                    this.txtRegion.Text = objRd["Region"].ToString();
                }
            }

            if (object.ReferenceEquals(objRd["PostalCode"], System.DBNull.Value))
            {
                this.txtPostalCode.Text = "N/A";
            }
            else
            {
                {
                    this.txtPostalCode.Text = objRd["PostalCode"].ToString();
                }
            }

            if (object.ReferenceEquals(objRd["Country"], System.DBNull.Value))
            {
                this.txtCountry.Text = "N/A";
            }
            else
            {
                {
                    this.txtCountry.Text = objRd["Country"].ToString();
                }
            }

            if (object.ReferenceEquals(objRd["HomePhone"], System.DBNull.Value))
            {
                this.txtHomePhone.Text = "N/A";
            }
            else
            {
                {
                    this.txtHomePhone.Text = objRd["HomePhone"].ToString();
                }
            }

            if (object.ReferenceEquals(objRd["Extension"], System.DBNull.Value))
            {
                this.txtExtension.Text = "N/A";
            }
            else
            {
                {
                    this.txtExtension.Text = objRd["Extension"].ToString();
                }
            }             
        
        
        }
        objCmd.Dispose();
        con.Close();
        con.Dispose();
    }
   

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string strCon = ConfigurationManager.AppSettings["con"] + "User ID=" + Session["user"] + ";Password=" + Session["pwd"];

        string SQL = "UPDATE Employees SET  LastName = '" + txtLastName.Text + "', " + 
                             "FirstName = '" + txtFirstName.Text + "', " +
                             "Title = '" + txtTitle.Text + "', " +
                             "TitleOfCourtesy = '" + txtTitleOfCourtesy.Text + "', " +
                             "BirthDate = '" + txtBirthDate.Text + "', " +
                             "HireDate = '" + txtHireDate.Text + "', " +
                             "Address = '" + txtAddress.Text + "', " +
                             "City = '" + txtCity.Text + "', " +
                             "Region = '" + txtRegion.Text + "', " +
                             "PostalCode = '" + txtPostalCode.Text + "', " +
                             "Country = '" + txtCountry.Text + "', " +
                             "HomePhone = '" + txtHomePhone.Text + "', " +
                             "Extension = '" + txtExtension.Text + "' " +  
                         "WHERE EmployeeID = " + txtID.Text;

        SqlConnection con = new SqlConnection();
        con.ConnectionString = strCon;
        con.Open();
        SqlCommand objCmd = new SqlCommand(SQL, con);
        SqlDataReader objRd = objCmd.ExecuteReader();

        lblRowsAffected.Text = "Updated (" + objRd.RecordsAffected + ") rows.";

        objRd.Close();
        objCmd.Dispose();
        con.Close();
        con.Dispose();
    }
}
