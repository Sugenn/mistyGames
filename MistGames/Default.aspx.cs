using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace MistGames
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataLayer.DataConnector datAss = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLED.12.0;Data Source='"+Server.MapPath("MainData.accdb")+"'; Persist Security Info=False;");
            DataTable dt = datAss.DataSelect("select UserID from tbl_login where Username = '"+txtUser.Text+"' and Password = '"+txtPassword.Text+"'");
            if (dt.Rows.Count > 0)
                Response.Redirect("Home.aspx");
        }
    }
}