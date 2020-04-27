using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection connection = new SqlConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
        string constring = File.ReadAllText(@"C:\Program Files (x86)\EMS\DB\ConnectionStringInput.txt", Encoding.UTF8);
        connection.ConnectionString = constring;
        if (Session["User"] != null)
        {
            Response.Redirect("~/Home.aspx");
        }
    }

    protected void loginbtn_Click(object sender, EventArgs e)
    {
        if (username.Text != "" && password.Text != "")
        {
            SqlCommand checkuser = new SqlCommand("SELECT Count(*) FROM Users WHERE user1 = @user AND pass1 = @pass", connection);
            checkuser.Parameters.AddWithValue("@user", username.Text.Trim());
            checkuser.Parameters.AddWithValue("@pass", password.Text.Trim());
            connection.Open();
            int UserExist = (int)checkuser.ExecuteScalar();
            connection.Close();
            if (UserExist > 0)
            {
                Session["User"] = username.Text;
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Write("<script>alert('إسم المستخدم أو كلمة المرور غير صحيحة!')</script>");
            }
        }
        if(username.Text =="" || password.Text =="")
        {
            Response.Write("<script>alert('الرجاء إدخال إسم المستخدم وكلمة المرور')</script>");
        }
    }
}