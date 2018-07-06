using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_list : System.Web.UI.Page
{
    service ser = new service();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = ser.all_users();
        GridView1.DataBind();
     
        if (!IsPostBack)
        {
            DropDownList1.DataSource = ser.all_rol();

            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ser.Id = Convert.ToInt32(txt_id.Text.Trim());
        ser.Name = txt_name.Text;
        ser.Password = txt_pass.Text;
        ser.Uname = txt_uname.Text;
        ser.Rol_id = Convert.ToInt32(DropDownList1.SelectedValue);
        ser.Update_users();
        GridView1.DataSource = ser.all_users();
        GridView1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ser.Id = Convert.ToInt32(txt_id.Text.Trim());
        ser.Delete_users();
        GridView1.DataSource = ser.all_users();
        GridView1.DataBind();

    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        txt_id.Text = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text.ToString();

        txt_name.Text = GridView1.Rows[e.NewSelectedIndex].Cells[2].Text.ToString();
        txt_uname.Text = GridView1.Rows[e.NewSelectedIndex].Cells[3].Text.ToString();
        txt_pass.Text = GridView1.Rows[e.NewSelectedIndex].Cells[4].Text.ToString();
        DropDownList1.SelectedValue = GridView1.Rows[e.NewSelectedIndex].Cells[5].Text.ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/default.aspx");
    }
}