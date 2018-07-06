using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class regester : System.Web.UI.Page
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
        ser.Name = txt_name.Text.Trim();
        ser.Uname = txt_uname.Text.Trim();
        ser.Password = txt_pass.Text.Trim();
        ser.Rol_id = Convert.ToInt32(DropDownList1.SelectedValue);
        if (ser.Insert_users() == true)
        {
            Response.Redirect("~/login.aspx");

        }
        else
        {
            Response.Write("خطا هنگام ثبت");
        }
    }
}