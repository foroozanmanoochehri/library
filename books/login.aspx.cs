using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    service ser = new service();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        DropDownList1.DataSource = ser.all_rol();
        DropDownList1.DataTextField = "Name";
        DropDownList1.DataValueField = "Id";
        DropDownList1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ser.Uname = txt_uname.Text.Trim();
        ser.Password = txt_pass.Text.Trim();
        ser.Rol_id = Convert.ToInt32(DropDownList1.SelectedValue);
        if (ser.login_user().Rows.Count > 0)
        {
            int user_id = Convert.ToInt32(ser.login_user().Rows[0][0]);
            int rol_id = Convert.ToInt32(ser.login_user().Rows[0][4]);

            if (rol_id == 1)
            {
                Response.Redirect("~/book_list.aspx?id=" + ser.last_id().Rows[0][0]);
            }
            else if (rol_id == 2)
            {
                Session.Add("admin", "ketabdar");
                Response.Redirect("~/admin/default.aspx");
                
            }
            else if (rol_id == 3)
            {
                Session.Add("admin", "admin");
                Response.Redirect("~/admin/default.aspx");
              
            }

        }
        else
        {
            Response.Write("نام کاربری یا رمز عبور اشتباه است");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/regester.aspx");
    }
}