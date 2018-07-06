using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_request : System.Web.UI.Page
{
    service ser = new service();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable my_dt = new DataTable();
            my_dt.Clear();
            my_dt.Columns.Add("Id");
            my_dt.Columns.Add("User_id");
            my_dt.Columns.Add("Book_id");
            my_dt.Columns.Add("Status_id");

            //my_dt.Rows.Add(o1);
            //my_dt.Rows.Add(o2);

            DataTable dt = ser.all_request();

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {

                int uid = Convert.ToInt32(dt.Rows[i][1]);
                int bid = Convert.ToInt32(dt.Rows[i][2]);
                int sid = Convert.ToInt32(dt.Rows[i][3]);
                ser.Id = uid;

                ser.Bookid = bid;
                ser.Statusid = sid;

                object[] o1 = { "1", ser.get_name().Rows[0][0], ser.get_book().Rows[0][0], ser.get_status().Rows[0][0] };

                my_dt.Rows.Add(o1);


            }
            GridView1.DataSource = my_dt;
            GridView1.DataBind();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/default.aspx");
    }
}