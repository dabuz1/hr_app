using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void homepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void profilepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Profilepage.aspx");
    }
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }
    protected void account_Click(object sender, EventArgs e)
    {
        Response.Redirect("Account.aspx");
    }
}
