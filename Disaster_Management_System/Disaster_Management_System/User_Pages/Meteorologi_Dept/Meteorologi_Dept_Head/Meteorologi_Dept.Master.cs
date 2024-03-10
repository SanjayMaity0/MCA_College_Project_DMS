using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Disaster_Management_System.User_Pages.Meteorologi_Dept
{
    public partial class Meteorologi_Dept : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAccountHolder.Text = Session["Auth_user_id"].ToString();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/Profile_Meteorologi_Head.aspx");
        }

        protected void btnDisaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/Disaster_Meteorologi_Head.aspx");
        }

        protected void btnteam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/Team_Meteorologi_Head.aspx");
        }

        protected void btnAlertsHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/AlertsHub_Meteorologi_Head.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/About_Meteorologi_Head.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/Help_Meteorologi_Head.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Home.aspx");
        }

        protected void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/Uoload_Image_Meteorologi_Head.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/Edit_Profile_Meteorologi_Head.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/View_Profile_Meteorologi_Head.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Meteorologi_Dept/Meteorologi_Dept_Head/Add_TeamMember_Meteorologi_Head.aspx");
        }
    }
}