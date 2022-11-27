using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace view
{
    public partial class view : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        Command cmnds = new Command();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void result_Click(object sender, EventArgs e)
        {
            dt= cmnds.slctName(Txt_input.Text);
            GridShow.DataSource = dt;
            GridShow.DataBind();

            if(GridShow.Rows.Count <= 0)
            {
                result_label.Text = "Not found matching";
            }
            else
            {
                result_label.Text = "";
            }
        }

       
    }
}