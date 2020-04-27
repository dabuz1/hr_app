using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
    [WebMethod]
    public static List<string> Getname(string name)
    {
        List<string> emp = new List<string>();
        string maincon = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        SqlConnection con = new SqlConnection(maincon);
        string query = string.Format("SELECT name FROM [dbo].[emp_info] WHERE name LIKE '{0}%'", name);
        con.Open();
        SqlCommand com = new SqlCommand(query, con);
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            emp.Add(dr.GetString(0));
        }
        con.Close();
        return emp;
    }
}