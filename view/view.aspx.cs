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
        bool TextChanged = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                this.DataBind();
            }
        }

        protected void result_Click(object sender, EventArgs e)
        {
            if(TextChanged)
            {
                Session["data"] = null;
            }
            this.BindGrid();
            TextChanged = false;

        }

        

        private void BindGrid()
        {
            if (Session["data"] == null)
            {
                dt = cmnds.slctName(Txt_input.Text);
                Session["data"] = dt;
            }
                GridShow.DataSource = Session["data"];
                GridShow.DataBind();
            

            if (GridShow.Rows.Count <= 0)
            {
                result_label.Text = "Not found matching";
            }
            else
            {
                result_label.Text = "";
            }
        }

        protected void GridShow_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridShow.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }

        protected void Txt_input_TextChanged(object sender, EventArgs e)
        {
            TextChanged = true;
        }
    }
}