using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Disaster_Management_System.General_Pages
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGeneral_Click(object sender, EventArgs e)
        {
            Session["Count"] = "One";
            Session["UserClass"] = "General";
            Response.Redirect("~/General_Pages/Registration.aspx");
        }

        protected void btnDDMO_Click(object sender, EventArgs e)
        {
            Session["Count"] = "One";
            Session["UserClass"] = "DDMO";
            Response.Redirect("~/General_Pages/Registration.aspx");
        }

        protected void btnMeteorologi_Click(object sender, EventArgs e)
        {
            Session["Count"] = "One";
            Session["UserClass"] = "Meteorologi";
            Response.Redirect("~/General_Pages/Registration.aspx");
        }

        protected void btnMedicalTeam_Click(object sender, EventArgs e)
        {
            Session["Count"] = "One";
            Session["UserClass"] = "Medical_Team";
            Response.Redirect("~/General_Pages/Registration.aspx");
        }
    }
}