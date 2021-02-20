using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using API_framework;

namespace API_test1
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<API_framework.Entites.entry> x = Program.Liststring();
            if (!Page.IsPostBack)
            {
                var list = Program.Liststring();
                // Add the data into ListView
                ListView1.DataSource = list;
                ListView1.DataBind();
      
            }
        }
    }
}