using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MistGames
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Request.Url.ToString().ToLower().IndexOf("default.aspx") > -1) || (Request.Url.ToString().ToLower().IndexOf(".aspx") ==  -1))
                pnMenuBoys.Visible = false;
            else
                pnMenuBoys.Visible = true;

        }
    }
}