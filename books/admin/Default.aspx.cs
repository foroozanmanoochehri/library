using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["admin"]!=null)
        {
            if (Session["admin"] == "ketabdar")
            {
                LinkButton2.Visible = false;
                LinkButton3.Visible = false;
                LinkButton4.Visible = false;
            }
        }
        else
        {
            Response.Redirect("~/login.aspx");
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/user_list.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/request.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/admin_book.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/zhaner.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Session["admin"] = null;
        Response.Redirect("~/login.aspx");
    }
}