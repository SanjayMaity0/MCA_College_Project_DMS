using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Disaster_Management_System.User_Pages.Disater_Management_Dept.Resque_Team.Resque_Team_Leader
{
    public partial class Resque_Team_Leader : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/Profile_Resque_Team_Leader.aspx");
        }

        protected void btnDisaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/Disaster_Resque_Team_Leader.aspx");
        }

        protected void btnteam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/Team_Resque_Team_Leader.aspx");
        }

        protected void btnAlertsHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/AlertsHubs_Resque_Team_Leader.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/About_Resque_Team_Leader.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/Help_Resque_Team_Leader.aspx");
        }

        protected void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/Upload_Image_Resque_Team_Leader.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/Edit_Profile_Resque_Team_Leader.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/View_Profile_Resque_Team_Leader.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Leader/Add_TeamMember_Resque_Team_Leader.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Home.aspx");
        }
    }
}