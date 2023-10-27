using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Data_Set_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection("data source=.; database=Employees; integrated security=SSPI"))
            //{
            //    SqlDataAdapter sda = new SqlDataAdapter("select * from emp", conn);
            //    DataSet ds = new DataSet();
            //    sda.Fill(ds);
            //    GridView1.DataSource = ds;
            //    GridView1.DataBind();
            //}

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Number");
            dt.Rows.Add("yash", "2365479");
            dt.Rows.Add("Ravi", "879027");
            dt.Rows.Add("Miral", "56347");
            dt.Rows.Add("karan", "34796");
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}