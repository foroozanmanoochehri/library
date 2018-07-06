using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_zhaner : System.Web.UI.Page
{
    service ser = new service();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {



            DropDownList1.DataSource = ser.all_Aenre();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/default.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ser.Id = Convert.ToInt32(DropDownList1.SelectedValue);
        ser.Name = TextBox1.Text;
        ser.Update_Aenre();
        DropDownList1.DataSource = ser.all_Aenre();
        DropDownList1.DataTextField = "Name";
        DropDownList1.DataValueField = "Id";
        DropDownList1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ser.Id = Convert.ToInt32(DropDownList1.SelectedValue);

        ser.Delete_Author();
        DropDownList1.DataSource = ser.all_Aenre();
        DropDownList1.DataTextField = "Name";
        DropDownList1.DataValueField = "Id";
        DropDownList1.DataBind();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ser.Name = TextBox1.Text;
        ser.Insert_Aenre();
        DropDownList1.DataSource = ser.all_Aenre();
        DropDownList1.DataTextField = "Name";
        DropDownList1.DataValueField = "Id";
        DropDownList1.DataBind();
    }
}