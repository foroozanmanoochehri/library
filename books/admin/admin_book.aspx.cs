using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin_book : System.Web.UI.Page
{
    service ser = new service();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = ser.all_book();
        GridView1.DataBind();
        if (!IsPostBack)
        {
            DropDownList1.DataSource = ser.all_Aenre();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ser.Name = txt_name.Text;
        ser.Author = txt_author.Text;
        ser.AuthorId = Convert.ToInt32(DropDownList1.SelectedValue);
        ser.Insert_book();
        GridView1.DataSource = ser.all_book();
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ser.Id = Convert.ToInt32(txt_id.Text);

        ser.Name = txt_name.Text;
        ser.Author = txt_author.Text;
        ser.AuthorId = Convert.ToInt32(DropDownList1.SelectedValue);
        ser.Update_book();
        GridView1.DataSource = ser.all_book();
        GridView1.DataBind();

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ser.Id = Convert.ToInt32(txt_id.Text);
        ser.Delete_book();
        GridView1.DataSource = ser.all_book();
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        txt_id.Text = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text.ToString();

        txt_name.Text = GridView1.Rows[e.NewSelectedIndex].Cells[2].Text.ToString();
        txt_author.Text = GridView1.Rows[e.NewSelectedIndex].Cells[3].Text.ToString();

        DropDownList1.SelectedValue = GridView1.Rows[e.NewSelectedIndex].Cells[4].Text.ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/default.aspx");
    }
}