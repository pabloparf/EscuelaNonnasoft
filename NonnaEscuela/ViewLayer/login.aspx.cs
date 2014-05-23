using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewLayer
{
    public partial class login : System.Web.UI.Page
    {
        User usuarioBL = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            { 
                string login = String.Format("{0}", Request.Form["username"]);
                string password = String.Format("{0}", Request.Form["password"]);

                usuarioBL.UserLogin(login, password);
            }
        }
    }
}