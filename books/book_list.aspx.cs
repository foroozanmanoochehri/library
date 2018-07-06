using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class book_list : System.Web.UI.Page
{
    int uid;
    
    service ser = new service();
    protected void Page_Load(object sender, EventArgs e)
    {

        uid = Convert.ToInt32(Request.QueryString["id"]);
            GridView1.DataSource = ser.all_book();
            GridView1.DataBind();
            DropDownList1.DataSource = ser.all_status();
      
        if(!IsPostBack)
        {
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }
      
        
            

    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        ListBox1.Items.Add(GridView1.Rows[e.NewSelectedIndex].Cells[1].Text);
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        for (int i = 0; i <= ListBox1.Items.Count - 1; i++)
        {

            ser.Userid = uid;
            ser.Bookid = Convert.ToInt32(ListBox1.Items[i].Value);
            ser.Statusid = Convert.ToInt32(DropDownList1.SelectedValue);
            ser.Insert_reques();
        }
        ListBox1.Items.Clear();
     
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/login.aspx");
    }
}