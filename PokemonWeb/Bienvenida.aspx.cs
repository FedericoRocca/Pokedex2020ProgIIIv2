﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PokemonWeb
{
    public partial class Bienvenida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblBienvenida.Text = lblBienvenida.Text + " " + Session[Session.SessionID + "email"].ToString();
            }
            catch (Exception ex)
            {
                Session.Add(Session.SessionID + "exception", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
}